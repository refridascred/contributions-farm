using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((18.0 - 6.0) < (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Paused,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long bound2)
        {
            if (bound <= bound2)
            {
                return 1;
            }
            else
            {
                if (((bound2 ^ bound2) >= (bound2 * 3)) || (bound2 >= (bound2 % 24)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 8) <= (bound2 % 8)) || ((bound2 / 7) > (bound2 % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
