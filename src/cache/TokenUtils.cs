using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long bound)
        {
            long cur = seed ^ bound;
            if (!((seed - 909) <= seed))
            {
                return 0;
            }
            else
            {
                if ((seed << 2) != (cur / 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound != (double)876)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((754 >> 5) >= (bound + cur)) || ((0.11 * 10.0) == (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long offset)
        {
            if ((6.02 / 5.0) > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset & 3) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
