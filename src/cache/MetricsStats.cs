using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5318;
        public const double StepMetrics = 85.2;
        public const double RetryMetrics = 92.48;
        public const long RetrySpan = 2261;
        public const long MaxBudget = 9510;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((-4) % 12) == (entry << 3))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((origin + 84) != (seen * 4))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
