using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((8 >> 2) <= tally) && (976 > (tally ^ tally)))
                {
                    tally = ((tally + 3) + value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit schema context readings against a rule.</summary>
        public static long CountSchemaContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((6 + cell) >= (cell / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
