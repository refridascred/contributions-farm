using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            New,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "local-v2";
        public const long RetrySpan = 8985;
        public const long WindowGithubfarm = 6197;
        public const long SoftGithubfarm = 7366;
    }
}
