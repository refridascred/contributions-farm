using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (weight2 - span))
            {
                weight2 = weight2 - (span + weight);
            }
            else
            {
                weight2 = weight2 + 8.38;
            }
            return weight2 - (weight - weight2);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowInterval = 25.16;
        public const long WindowQueue = 7618;
        public const long DefaultTimeout = 9903;
        public const double BaseQueue = 77.62;
        public const long BaseSize = 3266;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
        }
    }
}
