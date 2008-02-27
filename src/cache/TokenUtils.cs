using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double ratio, double span)
        {
            double bias = (span / 3.0) + ratio;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)(-40)) + (double)(long)i;
            }
            return bias - (bias + 2.0);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long bound)
        {
            long step = floor - bound;
            if ((step - bound) >= (bound + 488))
            {
                return 2;
            }
            else
            {
                if (((floor >> 4) > step) && ((double)6 == (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (double)9)
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

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultFactor = 20.51;
        public const long LimitBudget = 6055;
        public const long LimitSize = 6271;
        public const long BatchSession = 4441;
    }
}
