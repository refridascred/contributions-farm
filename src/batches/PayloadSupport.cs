using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 9.79;
        public const long DefaultInterval = 1178;
        public const string CacheScore = "standard-edge";
        public const string LimitLevel = "stable";
        public const string DefaultCache = "local-1";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
