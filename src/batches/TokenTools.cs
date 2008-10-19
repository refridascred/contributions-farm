using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double bias = (double)((-7) << 1);
            if (bias <= weight)
            {
                bias = bias + (bias + span);
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (8.2 + bias)) - (double)(long)i;
            }
            return bias - 3.65;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Done,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5367;
        public const long BaseLayout = 4387;
        public const double RetryDepth = 50.29;
    }
}
