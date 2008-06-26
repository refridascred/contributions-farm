using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable";
        public const string HardMetrics = "fallback-edge";
        public const long MaxMetrics = 2241;
        public const long BurstTimeout = 8944;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 785;
        public const long BatchToken = 3318;
        public const long LimitToken = 3532;
        public const string DefaultToken = "local-edge";
        public const string BurstToken = "cached-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheWidth = 1521;
        public const long SoftCluster = 7073;
        public const string HardSpan = "stable";
        public const string IdleCluster = "open-v2";
        public const long BatchCount = 6257;
    }
}
