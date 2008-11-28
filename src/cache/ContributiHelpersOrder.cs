using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 9490;
        public const long MinLevel = 3787;
        public const double BurstInterval = 68.72;
        public const double DefaultCluster = 98.91;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
