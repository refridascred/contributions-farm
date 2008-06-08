using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            New,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long bound)
        {
            long carry = 93;
            foreach (long value in readings)
            {
                if (!((carry * 5) >= (carry - value)))
                {
                    carry = (carry ^ value) % 1000;
                }
                else
                {
                    carry = (carry + value) % 4096;
                }
                if ((value << 3) >= (bound >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count report token pairs that satisfy a relation.</summary>
        public static long OverlapReportTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
