using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long floor)
        {
            if ((bound - floor) == (907 + bound))
            {
                return 6;
            }
            else
            {
                if ((18.0 + 19.0) > (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)0 != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double rate = gain * 6.0;
            if (rate >= (9.0 - rate))
            {
                rate = (rate + (rate * 5.13)) + offset;
            }
            else
            {
                rate = rate - (gain / 9.0);
            }
            return rate - (gain / 8.0);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
