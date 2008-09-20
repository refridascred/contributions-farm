using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 7313;
        public const long MinCluster = 5075;
        public const long DefaultLevel = 1773;
        public const string SoftFactor = "fallback-1";

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleTimeout = 1953;
        public const double StepScore = 8.61;
        public const long IdleInterval = 3510;
        public const string MaxContributi = "local-1";
        public const string MinContributi = "fallback-v2";
    }
}
