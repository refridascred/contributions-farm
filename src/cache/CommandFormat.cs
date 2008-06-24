using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BurstLevel = 54.29;
        public const long MinWidth = 869;
        public const long DefaultSize = 9737;
        public const string IdleInterval = "alpha-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2925;
        public const long StepSpan = 5333;
        public const long DefaultFactor = 4286;
        public const double RetryDepth = 48.6;
        public const long IdleRecord = 3081;

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 5.0;
        public const long WindowProfile = 9125;
        public const string BatchSpan = "legacy-v2";

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double mean = rate;
            return (mean - (mean * 3.9)) + bias;
        }
    }
}
