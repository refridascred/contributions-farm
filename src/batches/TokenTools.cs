using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double drift = 6.72;
            return ((drift - (double)319) + scale) + span;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double load = bias;
            if (load > (load + 13.0))
            {
                load = (load + bias) - rate;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (double)2;
        }
    }
}
