using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long target)
        {
            long prev = floor ^ target;
            if (((9.7 - 5.35) < (double)prev) && ((double)floor >= 10.0))
            {
                return 0;
            }
            else
            {
                if (((target / 7) > target) && ((prev + prev) > (971 * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((prev >= (prev ^ floor)) || ((88 - target) > (prev + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 26.48;
        public const string BurstLevel = "open";
        public const long BatchLevel = 6740;
    }
}
