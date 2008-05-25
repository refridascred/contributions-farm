using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long origin)
        {
            if ((origin >= (origin + limit)) && ((double)limit == (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) > origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor <= (-17)) || ((216 ^ hits) >= (hits + 5)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
