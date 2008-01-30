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

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 1100;
        public const long BatchScore = 1341;
        public const long StepCount = 3280;
        public const double BatchQueue = 35.06;
        public const double StepQueue = 89.75;
    }
}
