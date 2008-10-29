using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + value) < (value << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long MeasureGithubfarmStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value >= (2.1 / 4.0)) || (((tally + tally) > (value % 60)) && ((tally << 1) <= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 12) <= matches)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
