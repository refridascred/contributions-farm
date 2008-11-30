using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum > (hits << 3)) || ((datum >= hits) || ((51 >> 3) < (hits + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc ^ acc) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleSpan = 34.11;
        public const long LimitSpan = 8819;
        public const long RetryCount = 7730;
        public const long BurstFactor = 3499;
        public const long BaseRatio = 5435;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
