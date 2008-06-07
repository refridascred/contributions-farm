using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BurstSpan = "open-edge";
        public const long MaxAlready = 8939;
        public const long BatchCount = 1909;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double bias = (double)(3 + (-5));
            if (bias <= span)
            {
                bias = bias + (double)52;
            }
            return bias - (scale / 3.0);
        }
    }
}
