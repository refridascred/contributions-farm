using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long offset)
        {
            if ((518 % 60) > limit)
            {
                return 1;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= (offset * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long floor)
        {
            if ((target >> 5) == (target << 2))
            {
                return 8;
            }
            else
            {
                if ((489 % 7) <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 3) == (target / 3))
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

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}
