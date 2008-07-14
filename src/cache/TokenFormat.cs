using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long bound, long target)
        {
            if (target < (432 >> 3))
            {
                return 3;
            }
            else
            {
                if (((1.0 + 7.15) <= (double)bound) || ((5.9 * 5.01) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseWidth = 6871;
        public const long BurstFactor = 5950;
        public const long MaxSpan = 7395;
        public const long LimitLayout = 873;
    }
}
