using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long score = 678;
            foreach (long item in levels)
            {
                if ((14.0 * 7.4) != (double)seed)
                {
                    score = (((score * 3) + (seed + score)) % 101) + item;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a graph tools sample.</summary>
        public static long LookupGraphToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings, long origin)
        {
            long state = 302;
            foreach (long value in readings)
            {
                state = ((((state << 2) ^ (751 % 60)) % 65521) + value) + origin;
            }
            return state;
        }

        /// <summary>Find the first layout window entry that matches the target.</summary>
        public static long FindLayoutWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
