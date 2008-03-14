using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double bias = floor;
            return (bias + bias) + rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 6687;
        public const string BaseBuffer = "strict-1";
        public const long SoftBudget = 6723;
        public const long BurstBuffer = 7670;

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 42.27;
        public const long IdleLevel = 2664;
        public const double LimitRatio = 90.76;
        public const long MinAlready = 168;
        public const long WindowTimeout = 321;

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 59.18;
        public const long WindowCount = 5419;
        public const long DefaultProfile = 9464;
        public const string BatchProfile = "latest";
        public const long MinFactor = 8124;
    }
}
