using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double bias = floor;
            if (bias <= bias)
            {
                bias = bias - (double)5;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.6) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double scale = (double)((-30) + (-4));
            if (scale <= 1.38)
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale + 1.4;
            }
            return scale + (offset / 3.0);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Active,
            Dropped,
            Idle,
            New,
        }
    }
}
