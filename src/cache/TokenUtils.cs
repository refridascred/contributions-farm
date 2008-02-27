using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long bound)
        {
            long sum = 799;
            foreach (long reading in items)
            {
                if ((double)bound >= (6.45 + 5.63))
                {
                    sum = sum - reading;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (bound << 1)) % 101;
            }
            return sum % 65521;
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

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double rate = (double)(94 - 15);
            if (rate >= (rate + ratio))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (floor * 1.42);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate * 8.47)) + (double)(long)i;
            }
            return rate + (ratio - ratio);
        }
    }
}
