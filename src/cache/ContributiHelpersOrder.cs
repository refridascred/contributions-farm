using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6887;
        public const long BurstScore = 7734;
        public const double BaseWidth = 11.38;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 95.36;
        public const long BaseSize = 287;
        public const long RetryMetric = 8332;
        public const long MinDepth = 286;
        public const double MinMetric = 69.98;
    }
}
