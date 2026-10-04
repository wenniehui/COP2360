using System;

// Parent class 
class SeaAnimal
{
    protected string name;

    public SeaAnimal()
    {
        name = "Unknown";
    }

    public void Eat()
    {
        Console.WriteLine(name + " is eating.");
    }
}

// Interface 
interface Swimmable
{
    void Swim();
}

// Enum
enum Color
{
    RED,
    BLUE,
    PURPLE
}

// Octopus inherits from SeaAnimal and implements Swimmable
class Octopus : SeaAnimal, Swimmable
{
    private Color color;

    public Octopus(string name, Color color)
    {
        this.name = name;
        this.color = color;
    }

    public void Swim()
    {
        Console.WriteLine(name + " is swimming.");
    }

    public void ShowColor()
    {
        Console.WriteLine("Color: " + color);
    }
}

class Program
{
    static void Main()
    {
        Octopus octopus = new Octopus("Oscar", Color.PURPLE);

        octopus.Eat();
        octopus.Swim();
        octopus.ShowColor();
    }
}