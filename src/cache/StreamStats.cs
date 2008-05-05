using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 8.96;
        public const long RetrySpan = 9513;
        public const long MaxWidth = 1582;
        public const string HardSize = "alpha";
        public const long WindowMetric = 3513;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 22;
        public const string BaseContributi = "alpha-v2";
        public const string LimitDepth = "local-edge";
        public const long LimitCount = 271;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (double)target)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long limit)
        {
            long delta = floor + limit;
            if ((double)delta >= (4.0 * 5.7))
            {
                return 5;
            }
            else
            {
                if ((double)floor != (4.0 - 18.0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
