using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7605;
        public const long BaseQueue = 5145;
        public const string HardQueue = "standard-v2";
        public const long BurstDepth = 2037;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "strict-edge";
        public const long LimitScore = 3870;
        public const double BatchGraph = 14.48;
        public const string MinFactor = "cached-v2";
        public const long CacheGraph = 7950;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= 7.0)
            {
                rate2 = (rate2 + span) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + span;
        }
    }
}
