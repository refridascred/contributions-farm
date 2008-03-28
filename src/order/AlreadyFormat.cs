using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((entry + entry) <= (hits ^ hits)) || (entry <= hits)) && (hits < (hits - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout window sample.</summary>
        public static long LocateLayoutWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = 98;
            foreach (long reading in values)
            {
                if (((reading ^ carry) <= (carry - 110)) || (carry < (carry + reading)))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBudget = 34.3;
        public const long RetryCount = 2158;
        public const double BaseBatch = 77.54;
        public const string MinBatch = "staging";
        public const long SoftBatch = 6107;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = mix ^ limit;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
