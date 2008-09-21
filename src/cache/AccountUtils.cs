using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 9738;
        public const long MinSize = 1310;
        public const long RetryInterval = 7047;

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
