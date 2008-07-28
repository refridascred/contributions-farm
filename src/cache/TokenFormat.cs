using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double bias, double floor)
        {
            double mean = 5.0 + (double)1;
            if (mean <= floor)
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)54) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "alpha-v2";
        public const string CacheDepth = "stable-1";
        public const long BaseFilter = 149;
    }
}
