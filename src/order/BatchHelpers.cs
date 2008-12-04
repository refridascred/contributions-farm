using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long AuditStatsGithubfarmOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches - datum) >= (matches + 7))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }
    }
}
