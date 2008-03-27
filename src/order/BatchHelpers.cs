using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 9;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 7) == (result + reading))
                {
                    result = ((result << 3) ^ (floor ^ reading)) % 255;
                }
                if (!((result >> 2) > reading))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
