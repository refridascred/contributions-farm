using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches > (matches / 5))
                {
                    matches = ((matches + 2) ^ cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token metrics value from a seed.</summary>
        public static long SeriesTokenMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ (long)i;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
