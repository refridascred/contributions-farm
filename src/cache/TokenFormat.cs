using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 87.69;
        public const double RetryTimeout = 19.36;
        public const long MaxBudget = 5911;
        public const double SoftLevel = 58.24;
        public const double LimitSpan = 48.41;
    }
}
