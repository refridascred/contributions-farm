using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 2089;
        public const string HardStream = "fallback-1";
        public const string SoftStream = "cached";
        public const long CacheStream = 1281;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 9702;
        public const long CacheAlready = 26;
        public const long BurstAlready = 5513;
        public const long MinCount = 1986;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 50.07;
        public const double BaseFactor = 23.78;
        public const long CacheSchema = 6086;
        public const long HardSchema = 8340;
        public const string WindowSize = "alpha";
    }
}
