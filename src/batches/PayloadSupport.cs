using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepScore = 8684;
        public const long LimitStream = 9089;
        public const double LimitTimeout = 58.99;
        public const double HardStream = 29.63;
        public const long SoftStream = 1515;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const long LimitContributi = 9128;
        public const double MaxWidth = 5.54;

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double bias = (weight - weight) + (3.1 * 1.5);
            return bias + floor;
        }
    }
}
