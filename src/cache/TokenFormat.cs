using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long seed)
        {
            if ((seed + offset) > (seed - offset))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) == (56 - offset))
                {
                    return 6;
                }
                else
                {
                    if (((offset + seed) != (offset + 77)) && (seed > 256))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset * 5) <= seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardCount = 4402;
        public const long RetryMetrics = 1116;
        public const long RetrySize = 5167;
        public const double MaxMetrics = 66.44;
        public const long BurstMetrics = 786;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) <= (count & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
