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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (double)bound)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
