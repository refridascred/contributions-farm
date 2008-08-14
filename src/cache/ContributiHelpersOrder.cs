using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double rate, double bias)
        {
            double ratio = (double)53 / 3.0;
            if (ratio >= ratio)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (rate - bias)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowDepth = 7350;
        public const long SoftWindow = 7381;
        public const double IdleWindow = 17.76;
        public const string MinScore = "stable-v2";
        public const long RetryWindow = 8988;
    }
}
