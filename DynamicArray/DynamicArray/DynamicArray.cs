using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicArray
{
    class DynamicArray<T>

    /*
    Capacity
    size
    growth factor (e.g. C#=2)
    adding element
    insert element
    remove element
    */
    //Home Task


    //Implement Generic class DynamicArray

    /*API
     * Add – add item to array
     * Insert – add at specified index
     * Get – get item on specified position
     * Remove – remove item at specified index
     * Capacity – size of underlying data storage
     * Size – real count of elements
     */
    //Add maximum size(not capacity) of DynamicArray

    //Implement Stack and Queue using DynamicArray
    //Names: DynamicStack and DynamicQueue
    // Variables

    {
        private T[] Elements;
        private T[] Temp;
        private int Capacity;
        private int Size;
        private int GrowthFactor = 2;

        public void Add(T Value)
        {
            if (Size <= Elemants.Length)
            {
                array[Size] = Value;
            }
            else
            {
                T[] resizeArray = new T[Capacity * 2];
                for (int i = 0; i < resizeArray.Length; i++)
                {
                    resizeArray[i] = array[i];

                }

                array = resizeArray;
                resizeArray[Size] = Value;
            }


        }




    }
}
