using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double rate = bias * 7.51;
            if (rate >= (rate / 6.0))
            {
                rate = (rate + (double)1) - floor;
            }
            else
            {
                rate = rate - (double)475;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (6.14 + bias)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long step)
        {
            long gap = floor + step;
            if ((step ^ step) != (gap % 10))
            {
                return 1;
            }
            else
            {
                if (((-293) ^ step) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((floor + (-7)) >= 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor ^ 83) != (9 >> 3))
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

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
