using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchScore = 5958;
        public const string BurstCount = "alpha-v2";
        public const string IdleSize = "cached-v2";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            New,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Synced,
            Pending,
            Stale,
        }
    }
}
