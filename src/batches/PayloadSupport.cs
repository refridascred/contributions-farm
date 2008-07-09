using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ (long)i) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
