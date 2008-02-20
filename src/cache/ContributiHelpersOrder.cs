using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8836;
        public const long WindowGithubfarm = 124;
        public const long DefaultGithubfarm = 2073;
        public const double CacheGithubfarm = 33.74;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
