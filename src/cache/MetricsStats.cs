using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultInterval = 73.94;
        public const long StepRatio = 5339;
        public const string BurstEntry = "standard-v2";
        public const double CacheDepth = 93.47;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Stale,
            New,
            Retry,
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long CountPayloadFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Dropped,
            Ready,
            Idle,
        }
    }
}
