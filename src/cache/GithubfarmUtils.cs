using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSpan = 110;
        public const long CacheGithubfarm = 7990;
        public const long IdleRatio = 653;
        public const long BatchGithubfarm = 9509;
        public const string BatchTimeout = "fallback-edge";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 30.65;
        public const long CacheCluster = 6590;
        public const long MaxSpan = 6161;

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 50.91;
        public const double MinDepth = 84.27;
        public const double SoftBatch = 95.36;
        public const long DefaultTimeout = 7188;
    }
}
