using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Locked,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Dropped,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4490;
        public const long SoftFactor = 9869;
        public const long WindowFilter = 2510;
        public const double BatchScore = 21.22;
    }
}
