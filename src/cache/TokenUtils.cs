using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleFactor = 9291;
        public const long MinMetrics = 9574;
        public const double BurstMetrics = 9.55;
        public const long CacheBudget = 7893;
        public const double CacheCount = 54.35;
    }
}
