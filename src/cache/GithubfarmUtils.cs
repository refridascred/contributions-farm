using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 14.04;
        public const string CacheSpan = "stable-1";
        public const long BurstBudget = 737;

        /// <summary>Grade a support command value against two limits.</summary>
        public static long RankSupportCommand(long floor, long origin)
        {
            if (floor <= 86)
            {
                return 7;
            }
            else
            {
                if ((origin <= (origin % 12)) || ((origin + origin) < (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((235 % 10) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.6 * 5.0) > (double)origin)
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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double mean = scale;
            if (mean < offset)
            {
                mean = mean + (double)(-15);
            }
            return mean - scale;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Locked,
            Closed,
            Done,
        }
    }
}
