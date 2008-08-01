using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = load + (load + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)772;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series)
        {
            long carry = 92;
            foreach (long entry in series)
            {
                if (!((double)carry > 6.0))
                {
                    carry = (carry ^ entry) % 101;
                }
            }
            if (carry < 434)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }
    }
}
