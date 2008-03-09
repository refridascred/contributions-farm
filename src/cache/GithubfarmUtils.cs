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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3091;
        public const double WindowProfile = 12.12;
        public const long IdleInterval = 2935;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((9.0 * 7.37) > (double)(long)levels.Length)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
