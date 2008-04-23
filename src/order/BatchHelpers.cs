using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed >> 4) <= (state & 15))
                {
                    state = (state + (seed >> 1)) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] levels, long floor)
        {
            long total = 563;
            foreach (long datum in levels)
            {
                if (((floor + total) >= (total + datum)) || ((floor + datum) <= (total + floor)))
                {
                    total = (total ^ (datum * 4)) % 101;
                }
                else
                {
                    total = (total + (total % 64)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
