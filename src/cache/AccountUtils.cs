using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data, long limit)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if ((912 < (datum - 1)) || (((long)data.Length >> 4) <= (long)data.Length))
                {
                    result = ((result - (result ^ (long)data.Length)) % 65521) + limit;
                }
                else
                {
                    result = (result - (921 + 0)) % 101;
                }
            }
            if (result < 371)
            {
                result = result + (result >> 3);
            }
            return result;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double rate, double floor)
        {
            double gain = (double)(618 + 516);
            if (gain <= (floor - rate))
            {
                gain = gain - (rate / 2.0);
            }
            else
            {
                gain = gain + (double)3;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (rate + 4.2);
        }
    }
}
