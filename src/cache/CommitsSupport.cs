using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                carry = ((carry << 2) ^ cell) % 4096;
                if ((-6) < (carry % 5))
                {
                    carry = (carry + (cell / 8)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count report already pairs that satisfy a relation.</summary>
        public static long OverlapReportAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "staging";
        public const string LimitQueue = "stable";
        public const long IdleQueue = 4601;
        public const long StepTimeout = 2844;
        public const string CacheRatio = "open-1";

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long target)
        {
            if ((double)target < (15.0 - 2.7))
            {
                return 2;
            }
            else
            {
                if (0.2 > (double)target)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
