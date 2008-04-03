using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            long next = limit + limit2;
            if (((limit2 + limit2) < limit) || ((next >> 2) <= (limit / 4)))
            {
                return 0;
            }
            else
            {
                if (((limit - limit) <= (next >> 4)) && ((limit % 60) >= (limit * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((next < (limit + limit2)) && ((limit2 % 60) >= 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = -66;
            foreach (long entry in samples)
            {
                score = ((score * 5) + entry) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Retry,
            Locked,
            Closed,
            New,
        }
    }
}
