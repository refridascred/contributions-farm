using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double ratio = (scale / 7.0) / 6.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + floor;
            }
            return ratio + (scale * 9.7);
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long GradeFilterWindow(long floor, long offset)
        {
            long bound = floor ^ offset;
            if (!((bound + floor) >= (offset + 0)))
            {
                return 3;
            }
            else
            {
                if ((72 < (bound + bound)) || ((offset << 3) > 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long seed)
        {
            if ((2 / 5) >= (bound - bound))
            {
                return 2;
            }
            else
            {
                if (bound <= (seed >> 2))
                {
                    return 1;
                }
                else
                {
                    if (((seed + bound) <= (bound + seed)) && ((7.35 + 7.5) <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
