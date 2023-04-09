using System;
using System.Reflection;

public class AutoMovil
{
    public static string autoEleccion;

    static void Main()
    {
        Console.WriteLine("Bienvenidos al Sistema de Coches");
        menuAutos();
    }

    static void menuAutos()
    {
        Console.WriteLine();
        Console.WriteLine("Ingrese la Marca del Auto:");
        Console.WriteLine("(1) Audi | (2) Honda | (3) Mercedes \n");
        Console.Write("Ingreso: ");
        int selectAuto = Int16.Parse(Console.ReadLine());

        switch (selectAuto)
        {
            case 1:
                autoEleccion = "Audi";
                break;
            case 2:
                autoEleccion = "Honda";
                break;
            case 3:
                autoEleccion = "Mercedes";
                break;
            default:
                menuAutos();
                break;
        }
        Console.WriteLine($"\nSu auto es un {autoEleccion}.\n");
        menuAcciones();
    }

    static void menuAcciones()
    {
        Console.WriteLine("Ingrese la acción que realizara:");
        Console.WriteLine("(1) Acelerar | (2) Desacelerar | (3) Estacionar | (4) Selector Autos | (5) Salir \n");
        Console.Write("Ingreso: ");
        int accionAuto = Int16.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (accionAuto)
        {
            case 1:
                acelerarAuto();
                break;
            case 2:
                desacelerarAuto();
                break;
            case 3:
                estacionar();
                break;
            case 4:
                menuAutos();
                break;
            case 5:
                Console.WriteLine("Se ha finalizado el programa.");
                break;
            default:
                Console.WriteLine("Ingrese una opción valida.");
                break;
        }
    }

    static void acelerarAuto()
    {
        if (autoEleccion == "Audi")
        {
            for (int i = 0; i < 180; i+=10)
            {
                Console.WriteLine($"Su {autoEleccion} esta llendo a {i}Km/h.");
            }
            Console.WriteLine();
            menuAcciones();
        }
        else if (autoEleccion == "Honda")
        {
            for (int i = 0; i < 150; i+=5)
            {
                Console.WriteLine($"Su {autoEleccion} esta llendo a {i}Km/h.");
            }
            Console.WriteLine();
            menuAcciones();
        }
        else if (autoEleccion == "Mercedes")
        {
            for (int i = 0; i < 170; i+=15)
            {
                Console.WriteLine($"Su {autoEleccion} esta llendo a {i}Km/h.");
            }
            Console.WriteLine();
            menuAcciones();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Error...");
            menuAcciones();
        }
    }

    static void desacelerarAuto()
    {

       if (autoEleccion == "Audi")
        {
            for (int i = 180; i >= 0; i-=10)
            {
                Console.WriteLine($"Su {autoEleccion} esta llendo a {i}Km/h.");
            }
            Console.WriteLine();
            menuAcciones();
        }
        else if (autoEleccion == "Honda")
        {
            for (int i = 150; i >= 0; i-=5)
            {
                Console.WriteLine($"Su {autoEleccion} esta llendo a {i}Km/h.");
            }
            Console.WriteLine();
            menuAcciones();
        }
        else if (autoEleccion == "Mercedes")
        {
            for (int i = 170; i >= 0; i-=15)
            {
                Console.WriteLine($"Su {autoEleccion} esta llendo a {i}Km/h.");
            }
            Console.WriteLine();
            menuAcciones();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Error...");
            menuAcciones();
        }
    }

    static void estacionar()
    {
        Console.WriteLine($"Su {autoEleccion} se ha estacionado. \n");
        menuAcciones();
    }
}