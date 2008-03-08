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

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
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
