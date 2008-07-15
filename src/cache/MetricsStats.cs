using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long origin)
        {
            long prev = offset - origin;
            if ((offset * 5) < 81)
            {
                return 1;
            }
            else
            {
                if ((prev - origin) == (origin + offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) == (entry + 65))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 9537;
        public const double CacheSession = 65.14;
        public const long HardSession = 7365;
        public const string RetrySpan = "strict-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSpan = 46.31;
        public const long IdleMetric = 1386;
        public const string MaxDepth = "cached-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSpan = 2304;
        public const long StepEditor = 3941;
        public const long SoftEditor = 2749;
    }
}
