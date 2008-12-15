using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Dropped,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseCount = "latest";
        public const double StepMetric = 85.35;
        public const long StepFactor = 5110;
        public const string CacheMetric = "strict-1";
    }
}
