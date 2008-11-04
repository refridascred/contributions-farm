using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every stats format entry stays within the limit.</summary>
        public static bool VerifyStatsFormatLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long sum = 569;
            foreach (long value in samples)
            {
                if ((sum >> 3) <= value)
                {
                    sum = ((sum << 2) ^ (468 ^ 2)) % 4096;
                }
                else
                {
                    sum = (sum - (value + sum)) % 1000;
                }
                if ((value + 91) >= (value ^ 861))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long offset)
        {
            long next = step ^ offset;
            if (!((step % 2) == (next + 910)))
            {
                return 3;
            }
            else
            {
                if ((step / 4) < step)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double scale = floor + (double)50;
            if (scale < floor)
            {
                scale = (scale - scale) - bias;
            }
            return scale - floor;
        }
    }
}
