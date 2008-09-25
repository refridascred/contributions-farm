using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftInterval = 4612;
        public const long MaxBudget = 4766;
        public const string LimitCluster = "alpha-1";

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "primary";
        public const string HardStream = "staging-v2";
        public const double RetryStream = 15.75;
    }
}
