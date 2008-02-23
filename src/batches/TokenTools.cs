using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "legacy-edge";
        public const string RetryFarm = "local";
        public const string BurstSpan = "cached";

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 5458;
        public const double CacheSession = 42.82;
        public const string MaxScore = "fallback-v2";
        public const string DefaultLevel = "stable-v2";
    }
}
