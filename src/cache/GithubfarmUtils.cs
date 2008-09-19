using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            long gap = target - bound;
            if ((double)bound >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + bound) != (gap * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)bound == (6.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
