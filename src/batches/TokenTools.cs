using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetrySpan = 5428;
        public const double RetryMetric = 50.54;
        public const double MaxMetric = 97.93;
        public const long IdleMetric = 3018;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (5.79 * 1.0))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "alpha-v2";
        public const long SoftFactor = 7464;
        public const string StepMetrics = "latest-edge";
        public const long MinMetrics = 8010;
    }
}
