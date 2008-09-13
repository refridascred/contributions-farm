using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9907;
        public const string MinRoute = "open-1";
        public const long SoftWidth = 5404;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (floor - ratio))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (floor * 9.0);
            }
            return ratio2 + (double)99;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4283;
        public const string IdleContributi = "stable-edge";
        public const long BaseContributi = 9592;
        public const long HardTimeout = 3082;
        public const long BatchWidth = 2902;
    }
}
