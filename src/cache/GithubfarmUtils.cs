using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((entry - entry) >= (count / 3)) || (((double)1 <= (double)floor) || ((count + count) != (floor ^ floor))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Closed,
            Retry,
            New,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (0 < (sample + (-2)))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Dropped,
            Locked,
            Draft,
            Paused,
        }
    }
}
