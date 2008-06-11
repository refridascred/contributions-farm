using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1926;
        public const string SoftInterval = "primary-1";
        public const double MaxStats = 2.87;
        public const string BurstStats = "standard-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 5479;
        public const string HardTools = "stable";
        public const long BatchTools = 6913;
        public const long BurstCount = 20;
        public const long CacheDepth = 6633;
    }
}
