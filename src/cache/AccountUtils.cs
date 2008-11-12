using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + 896) == (item >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two format token measurements.</summary>
        public static double ScaleFormatToken(double rate, double bias)
        {
            double weight = rate;
            if (weight > bias)
            {
                weight = weight + (bias / 4.0);
            }
            else
            {
                weight = weight + (bias - bias);
            }
            return weight - (bias - 1.14);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftInterval = "stable-1";
        public const string BaseWindow = "alpha-1";
        public const double BatchRatio = 50.39;
        public const long BatchScore = 1445;
    }
}
