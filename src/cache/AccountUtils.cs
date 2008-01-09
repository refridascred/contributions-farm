using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double floor)
        {
            double drift = scale + (double)(-285);
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (floor - 5.21);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long floor)
        {
            if (((floor / 9) >= (floor & 1)) && (floor < 6))
            {
                return 8;
            }
            else
            {
                if ((716 + 110) > (floor / 6))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) < floor) || ((step - floor) == (step ^ floor)))
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

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
