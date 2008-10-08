using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitWidth = "local-1";
        public const string IdleBatches = "local";
        public const long LimitDepth = 7424;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double ratio2 = (double)(-736) * 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 + (floor - ratio2)) + (double)(long)i) - ratio;
            }
            return ratio2 - (floor / 2.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardInterval = "fallback-1";
        public const long CacheRoute = 1202;
        public const long DefaultSize = 8732;
        public const long SoftRatio = 6171;
        public const long CacheFactor = 8609;
    }
}
