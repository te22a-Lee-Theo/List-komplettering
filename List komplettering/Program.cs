List <string> names = new List<string> {"Anders", "Klas", "Filip"};

System.Console.WriteLine("You have a list with 3 names would you like to add names or would you like to print the list of names?");
System.Console.WriteLine("To add names type add and to print the list type print");
String Answer = Console.ReadLine();

while (true)
{
    if (Answer == "Add" || Answer == "add")
    {
        break;
    }
    else if (Answer == "Print" || Answer == "print")
    {
        break;
    }
    else
    {
        System.Console.WriteLine("Type a valid input");
        Answer = Console.ReadLine();
    }

}

if (Answer == "Add" || Answer == "add")
{
    names.Add(Console.ReadLine());
}

foreach (String name in names)
{
    System.Console.WriteLine(name);
}

Console.ReadLine();