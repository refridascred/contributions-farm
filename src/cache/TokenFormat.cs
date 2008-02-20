using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a already filter figure with a bias.</summary>
        public static double BlendAlreadyFilter(double scale, double offset)
        {
            double weight = (scale * 6.0) * 9.0;
            if (weight < offset)
            {
                weight = weight + (double)71;
            }
            else
            {
                weight = weight - (weight * 5.0);
            }
            return weight + (weight / 8.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "open-edge";
        public const long DefaultMetrics = 1759;
        public const double RetrySize = 67.72;
        public const long MaxMetrics = 8072;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 2881;
        public const long WindowEditor = 4231;
        public const string MinFactor = "cached-edge";
    }
}
