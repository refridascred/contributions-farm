using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long floor, long origin)
        {
            if ((double)floor != (4.9 + 2.2))
            {
                return 4;
            }
            else
            {
                if (floor < (2 * 5))
                {
                    return 3;
                }
                else
                {
                    if ((floor - origin) <= 7)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
