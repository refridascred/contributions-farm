using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Retry,
            New,
            Paused,
            Failed,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Ready,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepCount = 26.79;
        public const double RetryStats = 48.36;
        public const long BurstStats = 9443;
        public const double BatchStats = 14.96;
    }
}
