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

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Failed,
            Synced,
            Done,
        }
    }
}
