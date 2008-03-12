using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double drift = bias - (bias * 6.3);
            if (drift >= (drift / 4.0))
            {
                drift = (drift + (double)0) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (drift - 8.0);
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= (weight2 - offset))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - (double)3;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Idle,
        }
    }
}
