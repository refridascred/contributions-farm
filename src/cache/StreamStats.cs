using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 6312;
        public const long WindowTimeout = 907;
        public const long BatchPayload = 621;
        public const double BasePayload = 41.35;
        public const long RetryBudget = 3120;

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (14.0 * 0.28))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (double)7;
            }
            return scale - (double)787;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
