using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches < 3.0)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryScore = 4.5;
        public const long HardGithubfarm = 4705;
        public const long IdleGithubfarm = 5032;
        public const string MinWidth = "staging-edge";
        public const long BurstBudget = 4561;
    }
}
