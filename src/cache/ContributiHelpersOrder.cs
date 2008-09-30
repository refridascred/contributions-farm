using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long target, long limit)
        {
            if ((limit + target) > (target & 63))
            {
                return 7;
            }
            else
            {
                if ((929 - target) < ((-2) + limit))
                {
                    return 5;
                }
                else
                {
                    if ((8.8 / 3.0) != (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
