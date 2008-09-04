using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "fallback-v2";
        public const string BaseTimeout = "latest-edge";
        public const double LimitScore = 53.71;
        public const long WindowContext = 1663;
        public const double BurstDepth = 19.17;

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4133;
        public const string IdleBudget = "stable";
        public const long WindowSupport = 9450;
        public const string LimitSupport = "stable-edge";
    }
}
