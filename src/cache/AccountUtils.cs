using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstFactor = 53.39;
        public const double MaxGraph = 27.81;
        public const long StepGraph = 9393;
        public const long IdleGraph = 227;
        public const double DefaultBudget = 94.4;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((double)tally >= 1.8) && (((double)reading > (double)bound) || ((bound + reading) != (reading - 30))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
