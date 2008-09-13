using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinRatio = 76;
        public const long IdleTimeout = 1040;
        public const string IdleDepth = "strict-edge";
        public const double MinBuffer = 22.62;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinBudget = "standard-1";
        public const long LimitTools = 3124;
        public const string MinTools = "staging-v2";
        public const long BaseTools = 9330;
        public const double LimitSize = 73.48;
    }
}
