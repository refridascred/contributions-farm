using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 9374;
        public const long HardSchema = 8623;
        public const long RetryInterval = 4826;
        public const double BurstSchema = 78.83;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long MeasureFarmGithubfarmOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((floor % 2) < (floor + 537))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
