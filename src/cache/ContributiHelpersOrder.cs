using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long target)
        {
            long offset = limit ^ target;
            if ((double)limit >= (1.24 + 3.14))
            {
                return 2;
            }
            else
            {
                if ((offset <= (target + offset)) || ((double)target != (double)0))
                {
                    return 0;
                }
                else
                {
                    if ((target + 670) > (offset * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((2 + 131) < (target + limit)) || ((double)limit < (1.02 * 0.29)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long CountWindowChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - 820) >= (item & 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Idle,
            Synced,
            Ready,
        }
    }
}
