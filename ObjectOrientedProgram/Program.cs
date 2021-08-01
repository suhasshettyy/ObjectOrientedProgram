using ObjectOrientedProgram.InventoryManagement;
using ObjectOrientedProgramming.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string INVENTORY_JSON = @"C:\Users\DELL\source\repos\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.DisplayData(INVENTORY_JSON);
        }
    }
}
