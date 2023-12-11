var randNumber = new Random().Next(100);
int numberEntered;


do
{
    Console.WriteLine("Digite um número aleatório");
    numberEntered = int.Parse(Console.ReadLine()!);

    if (numberEntered > randNumber)
        Console.WriteLine("O número digitado é maior do que o número randômico");

    else if (randNumber > numberEntered)
        Console.WriteLine("O número digitado é menor do que o número randômico");
}

while (numberEntered != randNumber);

if (numberEntered == randNumber)
    Console.WriteLine("O jogo terminou");