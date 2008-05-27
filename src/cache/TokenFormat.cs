using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "standard-edge";
        public const double MaxScore = 23.56;
        public const string CacheRoute = "fallback";
        public const long MinRoute = 8479;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 6455;
        public const double BurstSize = 78.64;
        public const double IdleLevel = 73.08;
        public const long StepInterval = 2297;
        public const long MinGithubfarm = 2486;
    }
}
