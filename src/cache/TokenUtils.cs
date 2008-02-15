using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5006;
        public const string RetryMetric = "fallback";
        public const string BaseMetric = "staging-1";
        public const long WindowMetric = 9312;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 18.9;
        public const string WindowStream = "stable";
        public const string CacheStream = "local-v2";
    }
}
