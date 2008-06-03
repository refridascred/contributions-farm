using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next order farm value.</summary>
        public static double ScaleOrderFarm(double gain, double floor)
        {
            double bias = floor;
            if (bias >= gain)
            {
                bias = bias - (gain - gain);
            }
            return bias + 6.84;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 6628;
        public const double MaxTimeout = 46.7;
        public const long BurstTools = 7962;
        public const double LimitTools = 39.2;
        public const long StepTimeout = 359;
    }
}
