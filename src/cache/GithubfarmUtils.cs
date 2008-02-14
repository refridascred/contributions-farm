using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally <= (6.0 - 8.3))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 2889;
        public const long IdleBudget = 3606;
        public const double StepChannel = 42.35;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Active,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell << 2) > cell) && ((tally >> 5) < (1 ^ 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
