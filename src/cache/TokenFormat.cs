using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftBudget = 90.15;
        public const long BurstRatio = 6844;
        public const double SoftContributi = 47.49;
        public const double HardContributi = 4.03;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheTimeout = 91.76;
        public const string HardProfile = "alpha";
        public const string LimitProfile = "cached-edge";
        public const string IdleDepth = "cached-edge";
        public const long WindowDepth = 3898;
    }
}
