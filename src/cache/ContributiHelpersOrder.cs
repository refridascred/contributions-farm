using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - 249) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (8.5 <= (double)cell)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
