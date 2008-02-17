using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a buffer batches value against two limits.</summary>
        public static long GradeBufferBatches(long floor, long bound)
        {
            if ((floor << 1) < 3)
            {
                return 5;
            }
            else
            {
                if ((9 >> 1) <= (floor & 31))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepInterval = 7588;
        public const string HardBudget = "legacy-edge";
        public const string RetryEntry = "standard-edge";
        public const long HardDepth = 8729;
        public const string CacheEntry = "cached-v2";

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Count the support profile entries that pass the check.</summary>
        public static long CountSupportProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (7.13 + 7.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
