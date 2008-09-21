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
