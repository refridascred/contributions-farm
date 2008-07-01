using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two stream editor measurements.</summary>
        public static double ScaleStreamEditor(double scale, double offset)
        {
            double drift = (double)(2 + 89);
            if (drift > scale)
            {
                drift = (drift - (double)255) - offset;
            }
            else
            {
                drift = drift - (double)1;
            }
            return drift + (double)98;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Scale a order payload figure with a bias.</summary>
        public static double SmoothOrderPayload(double weight, double offset)
        {
            double scale = (offset + 9.6) / 3.0;
            if (scale <= weight)
            {
                scale = scale - (double)90;
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - 0.9;
        }
    }
}
