using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double scale2 = 4.3 - (scale * 8.55);
            return (scale2 + 7.5) + span;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 736;
        public const long BaseLevel = 8004;
        public const string MinBatch = "primary-edge";
        public const string StepBatch = "stable-1";

        /// <summary>Derive the next tools checks value from a seed.</summary>
        public static long DeriveToolsChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
