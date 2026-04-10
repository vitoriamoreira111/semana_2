var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");

// Constrói a aplicação
var app = builder.Build();

int resultado;


app.MapGet("/", () => {
    return Results.Ok("API funcionando ...");
});

// https://improved-xylophone-975g6rpw676h76pv.github.dev/calcula/10
app.MapGet("/calcula/{opcao}/{valor1}/{valor2}", (int opcao, int valor1, int valor2) => {
   switch(opcao){
    case 1:
        resultado = valor1 + valor2;
        return Results.Ok(new {
            operacao = "soma",
            valor1,
            valor2,
            resultado
        });
    case 2:
        resultado = valor1 - valor2;
        return Results.Ok(new {
            operacao = "subtração",
            valor1,
            valor2,
            resultado
        });
    case 3:
        resultado = valor1 * valor2;
        return Results.Ok(new {
            operacao = "multiplicação",
            valor1,
            valor2,
            resultado
        });
    case 4:
       resultado = valor1 / valor2;
        return Results.Ok(new {
            operacao = "divisão",
            valor1,
            valor2,
            resultado
        });
    default:
        return Results.BadRequest("Opção inválida.");
   }
    //Console.WriteLine("Valor: " + opcao);
    //return Results.Ok("API funcionando ...");
});

app.MapGet("/calcula/soma/{valor1}/{valor2}", (int valor1, int valor2) => {
   resultado = valor1 + valor2;
        return Results.Ok(new {
            operacao = "soma",
            valor1,
            valor2,
            resultado
});
});

app.MapGet("/calcula/subtracao/{valor1}/{valor2}", (int valor1, int valor2) => {
   resultado = valor1 - valor2;
        return Results.Ok(new {
            operacao = "subtração",
            valor1,
            valor2,
            resultado
});
});

app.MapGet("/calcula/multiplicacao/{valor1}/{valor2}", (int valor1, int valor2) => {
   resultado = valor1 * valor2;
        return Results.Ok(new {
            operacao = "multiplicação",
            valor1,
            valor2,
            resultado
});
});

app.MapGet("/calcula/divisao/{valor1}/{valor2}", (int valor1, int valor2) => {
   resultado = valor1 / valor2;
        return Results.Ok(new {
            operacao = "divisão",
            valor1,
            valor2,
            resultado
});
});

app.Run();

