using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a channel command figure with a bias.</summary>
        public static double ScaleChannelCommand(double gain, double floor)
        {
            double weight = 2.3 + floor;
            if (weight <= weight)
            {
                weight = (weight - 5.1) - gain;
            }
            return weight + (weight + 16.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxCount = "fallback-edge";
        public const long DefaultDepth = 3087;
        public const string SoftRatio = "fallback-1";
        public const long BatchRatio = 3080;
        public const double SoftSize = 49.78;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
