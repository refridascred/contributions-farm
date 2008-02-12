using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double rate = bias + (double)(-514);
            if (rate <= (double)61)
            {
                rate = (rate - (17.0 - 7.6)) + floor;
            }
            else
            {
                rate = rate - (rate / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - 19.0;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((102 + 28) > tally)
                {
                    tally = ((tally + 1) + datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples, long seed)
        {
            long sum = 41;
            foreach (long item in samples)
            {
                if (((1.14 - 17.0) == (double)seed) && ((seed >> 1) != (seed - (-7))))
                {
                    sum = (sum << 2) ^ item;
                }
            }
            if (sum > 3)
            {
                sum = sum ^ (seed - seed);
            }
            return sum;
        }
    }
}
