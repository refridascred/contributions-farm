using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double mean = offset / 6.0;
            if (mean >= (double)30)
            {
                mean = (mean + offset) + weight;
            }
            return mean + mean;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "open-v2";
        public const string IdleContributi = "local";
        public const string BaseContributi = "primary-v2";
        public const double BaseInterval = 65.87;
        public const string BatchRatio = "stable-edge";

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Failed,
            Retry,
            Synced,
            Ready,
        }
    }
}
