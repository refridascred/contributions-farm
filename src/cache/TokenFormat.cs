using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const double StepBuffer = 79.36;
        public const long WindowBuffer = 8955;
        public const double LimitLevel = 89.03;
        public const double BatchBuffer = 97.28;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long seed, long origin)
        {
            long slot = seed - origin;
            if (((seed & 1) == (origin + 11)) && ((seed - 735) > (slot << 3)))
            {
                return 8;
            }
            else
            {
                if (((double)(-14) == (double)seed) && (origin < (seed - origin)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long step)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = (((mark * 4) + (47 << 2)) % 255) - entry;
                mark = (mark ^ (mark ^ step)) % 4096;
            }
            return mark;
        }
    }
}
