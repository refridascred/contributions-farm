using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 97.23;
        public const string StepMetric = "alpha";
        public const double HardSize = 0.76;
        public const string HardMetric = "alpha-edge";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long origin)
        {
            long delta = bound + origin;
            if (((origin % 97) <= 64) || ((origin >> 4) > (bound + delta)))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) >= (delta % 97))
                {
                    return 4;
                }
                else
                {
                    if ((delta << 3) < (893 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next support farm value.</summary>
        public static double SmoothSupportFarm(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = rate - (ratio - bias);
            }
            return rate - ratio;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally ^ tally) <= tally)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
