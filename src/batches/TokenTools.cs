using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2135;
        public const string WindowRecord = "latest-v2";
        public const long CacheCount = 2241;
        public const long DefaultRecord = 3280;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Ready,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 9158;
        public const long MinCommits = 3864;
        public const double BaseCount = 17.23;
        public const double DefaultRatio = 77.93;
        public const double HardCommits = 19.18;
    }
}
