using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a checks channel value against two limits.</summary>
        public static long ClassifyChecksChannel(long bound, long offset)
        {
            if (((offset + 946) < offset) || ((bound / 6) >= bound))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound & 127))
                {
                    return 8;
                }
                else
                {
                    if ((9.84 + 8.2) > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "open-1";
        public const long IdleWidth = 9486;
        public const long LimitPayload = 1362;
        public const long BatchSpan = 5603;
        public const double BaseCount = 68.7;

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double bias2 = 5.11;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (bias2 * 1.0)) + (double)(long)i) + gain;
            }
            return bias2 + (bias - 6.83);
        }
    }
}
