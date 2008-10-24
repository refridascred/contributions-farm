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

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long target)
        {
            if ((target - 82) < (22 * 2))
            {
                return 0;
            }
            else
            {
                if (target <= origin)
                {
                    return 2;
                }
                else
                {
                    if (((target ^ target) >= origin) && ((839 & 255) == (origin + 27)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
