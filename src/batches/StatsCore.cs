using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long floor)
        {
            long gap = step + floor;
            if (((step & 7) != (step & 3)) && ((18 + 4) != (step ^ 296)))
            {
                return 0;
            }
            else
            {
                if (((double)step >= (double)floor) && ((step + step) > 6))
                {
                    return 8;
                }
                else
                {
                    if ((9.6 * 3.32) == (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor <= 3.17)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Idle,
            Paused,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFactor = 3383;
        public const long BurstFarm = 3596;
        public const long RetryFarm = 8840;
        public const long BurstTimeout = 9871;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Locked,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
