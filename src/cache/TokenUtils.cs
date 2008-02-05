using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinLevel = 66.9;
        public const string DefaultCache = "cached-1";
        public const string BatchCache = "strict";

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double weight, double span)
        {
            double scale = (span + span) - weight;
            if (scale < (weight * 18.0))
            {
                scale = scale - (weight - weight);
            }
            else
            {
                scale = scale - 7.7;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (span - weight)) + (double)(long)i;
            }
            return scale + (scale - 11.0);
        }
    }
}
