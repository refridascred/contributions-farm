using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long origin, long origin2)
        {
            if ((14.0 / 7.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((7.1 >= (double)origin) && (origin <= (origin2 - origin)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 <= (3.7 * 6.72))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= 2.0)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double rate = (gain + floor) * 17.0;
            if (rate >= (double)0)
            {
                rate = rate - (rate - floor);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (double)9;
        }
    }
}
