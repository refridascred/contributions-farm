using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7824;
        public const double SoftLevel = 85.19;
        public const long CacheEntry = 5345;

        /// <summary>Digest a series of metrics contributi entries.</summary>
        public static long ScoreMetricsContributi(long[] items)
        {
            long total = 82;
            foreach (long entry in items)
            {
                total = total + (entry + (long)items.Length);
                total = (total - (total / 7)) % 101;
                if (!(((long)items.Length + (-1)) > (6 / 3)))
                {
                    total = total - (entry - entry);
                }
                if (!(entry <= (-86)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a checks editor pair into a bucket.</summary>
        public static long SortChecksEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) != (68 ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
