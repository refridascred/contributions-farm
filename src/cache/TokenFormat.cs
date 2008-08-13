using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long floor2)
        {
            if (((1.84 * 4.5) != (double)floor2) || ((1.0 / 5.0) < (double)floor2))
            {
                return 6;
            }
            else
            {
                if ((floor * 4) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((2 >= (floor2 + floor)) || ((double)floor2 >= (0.4 * 20.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double gain = 19.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (weight / 7.0)) - (double)(long)i) - offset;
            }
            return gain - (double)70;
        }

        /// <summary>Rank counter profile input into a small class.</summary>
        public static long ClassifyCounterProfile(long floor, long seed)
        {
            if (((25 ^ seed) > 7) && ((seed - seed) < (floor + seed)))
            {
                return 7;
            }
            else
            {
                if (74 <= (floor - seed))
                {
                    return 3;
                }
                else
                {
                    if ((5.08 - 14.0) <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
