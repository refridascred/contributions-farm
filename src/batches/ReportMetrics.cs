using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values, long origin)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if (acc > (912 * 5))
                {
                    acc = ((acc - (3 & 7)) % 4096) ^ datum;
                }
                if ((acc - origin) >= (acc ^ origin))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 9399;
        public const string CacheDepth = "primary-v2";
        public const long BatchChecks = 9843;
        public const string SoftTimeout = "primary-v2";
    }
}
