using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Idle,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 7458;
        public const long IdleWidth = 2539;
        public const long WindowReport = 9317;
        public const long CacheReport = 3674;
        public const long DefaultCount = 4852;
    }
}
