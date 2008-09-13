using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9907;
        public const string MinRoute = "open-1";
        public const long SoftWidth = 5404;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (floor - ratio))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (floor * 9.0);
            }
            return ratio2 + (double)99;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheTimeout = 6440;
        public const long SoftDepth = 6838;
        public const long RetryRatio = 1988;
        public const long MaxBatch = 6228;
        public const long CacheBatch = 5865;
    }
}
