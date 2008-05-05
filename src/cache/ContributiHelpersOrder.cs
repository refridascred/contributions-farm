using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2596;
        public const long StepRecord = 5470;
        public const string DefaultRecord = "fallback-1";
        public const double MinCount = 65.69;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            New,
            Retry,
            Failed,
        }
    }
}
