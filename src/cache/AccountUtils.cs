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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxFactor = "local-1";
        public const long BatchContributi = 1316;
        public const long RetryContributi = 5132;
        public const string RetryFactor = "standard-edge";

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
