using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long origin, long seed)
        {
            if (!((3.0 * 2.4) < (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin + 90) != (seed + origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Retry,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 34.01;
        public const double RetryLevel = 94.34;
        public const string CacheSize = "staging-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 4101;
        public const long SoftWidth = 9731;
        public const long LimitFactor = 8771;
        public const long MinLayout = 4991;

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 89.97;
        public const long LimitStream = 9128;
        public const string IdleBudget = "local-1";
        public const double IdleStream = 4.82;

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
