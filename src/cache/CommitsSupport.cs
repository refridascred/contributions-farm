using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long origin)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = ((total + sample) % 255) + origin;
            }
            return total;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long origin)
        {
            if ((double)target >= 5.89)
            {
                return 0;
            }
            else
            {
                if (((origin * 4) >= (origin / 9)) || ((17.0 * 0.75) > (double)target))
                {
                    return 8;
                }
                else
                {
                    if (19.0 > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target - 9) == (8 >> 1)) || (target < (target + origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Ready,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Failed,
            Paused,
            Done,
        }
    }
}
