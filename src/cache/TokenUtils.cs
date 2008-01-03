using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1490;
        public const string DefaultLevel = "alpha-1";
        public const string MinDepth = "fallback-v2";
        public const long CacheAccount = 5798;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 9192;
        public const long BaseStream = 9007;
        public const long LimitWidth = 2742;
        public const double LimitStream = 37.41;
        public const long DefaultWidth = 520;
    }
}
