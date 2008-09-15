using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 6.11;
        public const long BatchMetric = 731;
        public const long HardMetric = 8597;

        /// <summary>Fold a list of contributi githubfarm readings.</summary>
        public static long TotalContributiGithubfarm(long[] series)
        {
            long sum = 900;
            foreach (long value in series)
            {
                sum = sum + (value + value);
            }
            return sum % 4096;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
