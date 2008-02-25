using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2835;
        public const long BurstTimeout = 2536;
        public const long WindowCount = 8151;

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleRatio = 19.42;
        public const double BatchFactor = 76.11;
        public const double BaseFarm = 72.85;
        public const string CacheBudget = "staging-v2";
        public const double RetryFarm = 7.22;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
