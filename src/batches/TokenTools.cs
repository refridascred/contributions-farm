using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Retry,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 5458;
        public const double CacheSession = 42.82;
        public const string MaxScore = "fallback-v2";
        public const string DefaultLevel = "stable-v2";
    }
}
