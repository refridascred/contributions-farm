using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the command stats entries that pass the check.</summary>
        public static long CountCommandStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value ^ hits) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long limit)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (((sum << 2) ^ (limit % 5)) % 4096) ^ datum;
            }
            return sum;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(((double)target > (4.6 - 4.27)) || ((6.2 - 4.1) <= (double)target)))
                {
                    long gap = -7;
                    acc = acc ^ (gap - gap);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
