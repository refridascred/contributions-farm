using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a contributi route value against two limits.</summary>
        public static long ClassifyContributiRoute(long target, long origin)
        {
            if ((3 + target) <= origin)
            {
                return 2;
            }
            else
            {
                if ((39 - target) <= (target - 956))
                {
                    return 1;
                }
                else
                {
                    if ((target << 3) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 97) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double ratio = 20.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (((ratio - (double)5) + (double)(long)i) + bias) + floor;
            }
            return ratio + (ratio * 4.0);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
