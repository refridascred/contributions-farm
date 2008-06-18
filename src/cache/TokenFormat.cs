using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (limit >= (limit << 1))
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((count & 1) > count))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
