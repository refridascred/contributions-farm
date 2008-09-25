using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2803;
        public const string StepFilter = "cached-1";
        public const double HardScore = 55.54;
        public const long SoftSpan = 4234;

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
