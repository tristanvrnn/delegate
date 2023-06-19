using System;

public class Program
{
    public static void Main(string[] args)
    {
        ShowMoney showMoneyDelegate = ShowInDollars;
        showMoneyDelegate += ShowInEuros;

        decimal amount = 80.50m;

        showMoneyDelegate(amount);
    }

    public delegate void ShowMoney(decimal amount);

    public static void ShowInDollars(decimal amount)
    {
        Console.WriteLine("Amount in dollars: " + amount + "$");
    }

    public static void ShowInEuros(decimal amount)
    {
        Console.WriteLine("Amount in euros: " + amount + "€");
    }
}
