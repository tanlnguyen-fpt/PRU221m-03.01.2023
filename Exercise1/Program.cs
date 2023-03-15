// See https://aka.ms/new-console-template for more information
Console.Write("Enter number: ");
var input = Console.ReadLine();

try
{
    int number = int.Parse(input);
}
catch (FormatException)
{

    Console.WriteLine("Format Exception!");
}
catch (OverflowException)
{
    Console.WriteLine("Overflow Exception!");
}
finally
{
    Console.WriteLine("This is the final block");
}



