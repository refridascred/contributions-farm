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

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 7024;
        public const double MaxRatio = 23.36;
        public const long MinCounter = 1780;

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
