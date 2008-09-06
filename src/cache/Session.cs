using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + matches) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long floor)
        {
            long prev = origin + floor;
            if (((origin % 100) > (prev % 100)) || ((910 + 20) >= (floor & 31)))
            {
                return 1;
            }
            else
            {
                if ((prev << 1) < origin)
                {
                    return 3;
                }
                else
                {
                    if (10 < (prev * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Paused,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long origin)
        {
            if ((double)origin >= (0.2 + 4.2))
            {
                return 1;
            }
            else
            {
                if (step > origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
