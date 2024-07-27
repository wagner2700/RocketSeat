// See https://aka.ms/new-console-template for more information


//Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida

var nome = Console.ReadLine();

Console.WriteLine("Olá, " + nome + "! Seja muito bem-vindo!");

var sobrenome=  Console.ReadLine();

 var nomeCompleto = nome + " " + sobrenome;
Console.WriteLine(nomeCompleto);

/*1.Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
    -A soma entre esses dois números;
-A subtração entre os dois números;
-A multiplicação entre os dois números;
-A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
-A média entre os dois números.*/

double valor1 = 5;
double valor2 = 10.5;

var subtracao = valor1 - valor2;
var mul = valor1 * valor2;
var div = valor1 / valor2;
var media  = valor1 + valor2  / 2;

Console.WriteLine(subtracao.ToString() + " - " + mul.ToString() + " - " + div.ToString() + " - " + media.ToString());