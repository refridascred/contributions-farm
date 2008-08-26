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

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + result) % 4096;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
