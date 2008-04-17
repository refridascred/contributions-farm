using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftSpan = 59.13;
        public const long WindowWidth = 4392;
        public const long BatchSize = 421;
        public const long CacheChannel = 4982;

        /// <summary>Combine payload stats values into a single score.</summary>
        public static long FoldPayloadStats(long[] samples, long bound)
        {
            long acc = -969;
            foreach (long reading in samples)
            {
                acc = ((acc * 4) + reading) % 255;
                acc = (acc + (9 ^ bound)) % 4096;
                if (acc > (bound % 10))
                {
                    acc = (acc - (9 & 1)) % 4096;
                }
            }
            return acc;
        }
    }
}
