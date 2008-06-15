using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long limit)
        {
            if (17 >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if (475 > (limit / 2))
                {
                    return 4;
                }
                else
                {
                    if (((double)511 <= (double)limit) || ((7.53 / 6.0) < (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a format cluster figure with a bias.</summary>
        public static double ScaleFormatCluster(double rate, double floor)
        {
            double drift = (rate / 6.0) + floor;
            if (drift > (floor + rate))
            {
                drift = drift + (double)(-2);
            }
            return drift + rate;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (0.72 + 8.1))
                {
                    count = ((count + 3) ^ item) - step;
                }
            }
            return count;
        }
    }
}
