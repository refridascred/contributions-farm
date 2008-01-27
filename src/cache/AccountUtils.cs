using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 7.0)) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseTimeout = 6395;
        public const long MaxTimeout = 9345;
        public const long BaseDepth = 477;

        /// <summary>Scale a entry profile figure with a bias.</summary>
        public static double ScaleEntryProfile(double scale, double offset)
        {
            double rate = scale;
            return (rate + (rate / 5.0)) + offset;
        }
    }
}
