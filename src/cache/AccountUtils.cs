using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every commits queue entry stays within the limit.</summary>
        public static bool CheckCommitsQueueBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next metric order value.</summary>
        public static double SmoothMetricOrder(double rate, double bias)
        {
            double ratio = (double)(2 + (-7));
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + ratio) + (double)(long)i) + rate) - bias;
            }
            return ratio + (double)56;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long step2)
        {
            if (step > (step >> 2))
            {
                return 0;
            }
            else
            {
                if ((1.38 / 4.0) < (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((4.9 + 8.47) > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step > (4.0 + 3.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
