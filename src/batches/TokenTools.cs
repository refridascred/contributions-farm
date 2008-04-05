using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstTimeout = 55.91;
        public const string RetryStream = "strict-edge";
        public const long CacheStream = 6724;
        public const long MinScore = 6016;

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "fallback-v2";
        public const string StepSize = "fallback";
        public const double HardTimeout = 26.9;
        public const long BurstWidth = 8913;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }
    }
}
