using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            New,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5318;
        public const double StepMetrics = 85.2;
        public const double RetryMetrics = 92.48;
        public const long RetrySpan = 2261;
        public const long MaxBudget = 9510;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long step)
        {
            long score = 82;
            foreach (long value in series)
            {
                score = (((score - (0 + score)) % 255) - value) + step;
            }
            return score % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 1967;
        public const long SoftDepth = 8683;
        public const long CacheEntry = 2150;
        public const long IdleEntry = 2517;

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "fallback-1";
        public const long RetryRatio = 3197;
        public const string SoftAlready = "local";
        public const long IdleAlready = 7340;
        public const long WindowAlready = 9732;
    }
}
