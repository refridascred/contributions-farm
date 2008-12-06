using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Synced,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            if (((bound - floor) <= (79 * 2)) || ((floor / 5) <= bound))
            {
                return 7;
            }
            else
            {
                if ((floor * 3) == (floor + bound))
                {
                    return 6;
                }
                else
                {
                    if (floor > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor != (3.8 + 4.17))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 4915;
        public const long SoftCache = 3122;
        public const long IdleBudget = 2920;
        public const double BurstCount = 23.8;
        public const long MaxCache = 1934;
    }
}
