using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (1.51 >= (double)seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 4945;
        public const string MaxBudget = "legacy-1";
        public const long BaseGraph = 7241;
        public const double BurstGraph = 71.62;
        public const long RetryLevel = 9109;

        /// <summary>Accumulate contributi context samples.</summary>
        public static long DigestContributiContext(long[] values, long seed)
        {
            long sum = 246;
            foreach (long value in values)
            {
                sum = ((sum ^ (97 - value)) % 255) + seed;
                sum = sum + value;
            }
            if (sum > 823)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryBudget = 3884;
        public const long CacheProfile = 1708;
        public const long BurstDepth = 2658;
        public const string BaseProfile = "fallback-1";
        public const long DefaultBudget = 589;
    }
}
