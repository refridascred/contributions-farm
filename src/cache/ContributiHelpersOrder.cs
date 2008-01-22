using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 1080;
        public const string BurstGithubfarm = "primary-1";
        public const long DefaultWidth = 9313;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)seed >= (4.0 + 5.0))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Done,
            Pending,
            New,
            Synced,
        }
    }
}
