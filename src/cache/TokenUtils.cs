using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Done,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 30.01;
        public const double DefaultCount = 36.2;
        public const long DefaultMetric = 1365;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }
    }
}
