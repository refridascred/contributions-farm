using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 8731;
        public const long SoftFactor = 6828;
        public const long DefaultMetrics = 5804;
        public const string CacheSize = "open-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCommand = "legacy-1";
        public const long MaxCommand = 9070;
        public const long BurstCommand = 3;
    }
}
