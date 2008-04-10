using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio / 8.0))
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 1.5) + (double)(long)i;
            }
            return ratio - (double)1;
        }

        /// <summary>Rank schema counter input into a small class.</summary>
        public static long RankSchemaCounter(long floor, long offset)
        {
            if ((1.4 - 7.97) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((double)offset != (5.0 + 8.7)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double scale = (floor + floor) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (rate - floor)) + (double)(long)i;
            }
            return scale - (scale + 9.6);
        }
    }
}
