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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxFactor = 1817;
        public const double BurstRatio = 10.95;
        public const long SoftBuffer = 3262;
        public const string RetryInterval = "strict-edge";

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double bias = (weight - weight) + (3.1 * 1.5);
            return bias + floor;
        }
    }
}
