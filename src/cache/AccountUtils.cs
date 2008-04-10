using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((700 & 127) < (hits - limit)) && (limit >= (limit + limit)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
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
