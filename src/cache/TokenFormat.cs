using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8168;
        public const long MaxCluster = 2103;
        public const long SoftSpan = 5793;
        public const string BaseCluster = "primary-1";
        public const string SoftCluster = "alpha-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "primary-edge";
        public const string BatchRatio = "local-edge";
        public const string MinEntry = "standard-v2";
        public const string CacheEntry = "cached";
        public const long CacheWidth = 3656;
    }
}
