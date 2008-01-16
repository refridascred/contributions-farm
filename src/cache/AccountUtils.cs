using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long seed, long floor)
        {
            long bound = seed - floor;
            if (bound >= (seed / 2))
            {
                return 5;
            }
            else
            {
                if ((bound ^ floor) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((6.28 * 11.0) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + 267) == (floor - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long origin, long step)
        {
            long bound = origin ^ step;
            if ((bound ^ bound) != (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((double)step == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
