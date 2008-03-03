using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Classify a format metric pair into a bucket.</summary>
        public static long RankFormatMetric(long bound, long seed)
        {
            if (((44 - 9) < seed) && ((20.0 + 13.0) >= (double)seed))
            {
                return 4;
            }
            else
            {
                if (((bound / 6) != (seed + 36)) && ((seed % 60) > (bound * 2)))
                {
                    return 2;
                }
                else
                {
                    if (((76 / 7) <= (bound + seed)) || ((seed + bound) == (seed - seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double weight2 = 1.4;
            if (weight2 >= (double)1)
            {
                weight2 = weight2 + (weight2 - weight2);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (span / 9.0)) + (double)(long)i;
            }
            return weight2 + (5.0 - weight);
        }

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool CheckReportFarmLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
