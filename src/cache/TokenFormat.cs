using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8807;
        public const long BurstEditor = 2090;
        public const string IdleEditor = "standard-edge";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 38.0;
        public const long WindowContributi = 2133;
        public const long HardDepth = 4922;
    }
}
