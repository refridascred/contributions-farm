using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long floor)
        {
            if ((double)seed != (1.6 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((seed & 1) >= 0)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (entry << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long target)
        {
            if ((6 ^ floor) != (75 << 1))
            {
                return 8;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Retry,
            Synced,
        }
    }
}
