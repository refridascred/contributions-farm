using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 2203;
        public const double IdleSize = 42.63;
        public const double BatchEntry = 32.34;
        public const double BaseEntry = 30.04;

        /// <summary>Project the next notes checks value.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double bias = 10.0;
            if (bias <= scale)
            {
                bias = bias + (double)33;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias * 9.44)) + (double)(long)i;
            }
            return bias - (offset + scale);
        }
    }
}
