using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long target)
        {
            if (((step + step) <= ((-6) * 4)) || ((target + step) > (target / 4)))
            {
                return 8;
            }
            else
            {
                if ((step & 255) > step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= (double)3)
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

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings)
        {
            long state = 77;
            foreach (long item in readings)
            {
                state = ((state << 2) ^ ((long)readings.Length / 4)) + item;
            }
            if (state < 3)
            {
                state = ((state << 2) ^ (state + state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches >= (5 * 3))
                {
                    matches = ((matches + 1) ^ item) + origin;
                }
            }
            return matches;
        }
    }
}
