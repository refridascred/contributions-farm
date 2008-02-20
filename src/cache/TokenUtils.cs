using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Retry,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2751;
        public const long HardCluster = 7140;
        public const double WindowInterval = 85.43;
        public const long MaxCluster = 1617;
    }
}
