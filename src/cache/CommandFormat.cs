using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 8848;
        public const string BaseInterval = "fallback";
        public const long WindowFactor = 7066;
        public const long CacheCommand = 8419;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepDepth = "latest-v2";
        public const long BaseMetrics = 3601;
        public const string MaxMetrics = "legacy-v2";
        public const double MinCount = 37.32;
        public const long RetryMetrics = 9673;

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryBudget = 45.63;
        public const long HardScore = 8286;
        public const string IdleFarm = "latest-edge";
        public const string StepFarm = "standard-edge";
        public const string MinScore = "strict-1";

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long MeasureStreamOrderMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) > 64) && ((hits / 7) != (origin >> 5)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
