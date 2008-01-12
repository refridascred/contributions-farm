using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long origin)
        {
            if ((origin << 1) >= floor)
            {
                return 3;
            }
            else
            {
                if ((6.37 - 4.4) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin >= (9.57 - 9.75)) || ((2.01 - 10.0) < (double)origin))
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

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long target)
        {
            if (((limit / 7) >= limit) || ((limit + target) > (target + 67)))
            {
                return 5;
            }
            else
            {
                if (!(target < limit))
                {
                    return 6;
                }
                else
                {
                    if (5.1 >= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((76 - limit) <= 2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Retry,
            Failed,
            New,
            Done,
        }
    }
}
