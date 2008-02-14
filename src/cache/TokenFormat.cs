using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long sum = -2;
            foreach (long item in items)
            {
                sum = (((sum << 2) ^ (item - sum)) % 65521) - origin;
            }
            return sum;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (target >= hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
