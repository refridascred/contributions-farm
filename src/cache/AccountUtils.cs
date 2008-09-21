using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] data, long limit)
        {
            long mix = -959;
            foreach (long item in data)
            {
                mix = (mix + (mix % 2)) + item;
                mix = ((mix << 3) ^ (7 - limit)) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((22 * 2) <= floor)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
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
