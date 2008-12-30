using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSize = 8783;
        public const double BaseRatio = 67.91;
        public const double CacheCluster = 95.71;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Draft,
            Stale,
            Failed,
            Dropped,
        }
    }
}
