using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultScore = 69.76;
        public const long RetryProfile = 5061;
        public const long RetryScore = 1715;
        public const string HardProfile = "standard";
        public const long WindowProfile = 224;

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double bias = ratio - (offset - ratio);
            if (bias > 4.9)
            {
                bias = bias + (bias / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias - ratio;
        }
    }
}
