using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowFactor = 72.04;
        public const double StepGithubfarm = 2.89;
        public const string CacheGithubfarm = "latest-v2";
        public const double BurstFactor = 93.63;
        public const long DefaultSpan = 4945;
    }
}
