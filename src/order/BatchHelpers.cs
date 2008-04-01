using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next metric tools value from a seed.</summary>
        public static long IterateMetricTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((acc * 5) < limit)
                {
                    long step = ((long)i + acc) + (acc - limit);
                    acc = (acc - (step % 60)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc - (acc >> 3)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long limit)
        {
            long total = 2;
            foreach (long item in levels)
            {
                if (((item - total) >= total) && ((double)item >= (4.0 / 8.0)))
                {
                    total = ((total ^ (5 >> 5)) % 97) - limit;
                }
            }
            return total;
        }
    }
}
