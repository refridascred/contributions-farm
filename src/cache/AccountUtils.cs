using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long target)
        {
            if ((target - step) >= (73 % 5))
            {
                return 4;
            }
            else
            {
                if (((target - target) <= step) || ((step % 8) >= (step ^ step)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 5342;
        public const double MinWidth = 39.41;
        public const long HardBudget = 3232;
        public const string DefaultWidth = "cached-edge";
    }
}
