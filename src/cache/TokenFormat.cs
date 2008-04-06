using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseWidth = 60.19;
        public const long BatchSession = 722;
        public const double MaxInterval = 48.96;

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double bias = (double)(2 + 47);
            if (bias >= span)
            {
                bias = bias - 7.9;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 7.56) + (double)(long)i;
            }
            return bias - (ratio * 4.6);
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Draft,
            Locked,
            Stale,
            Closed,
        }
    }
}
