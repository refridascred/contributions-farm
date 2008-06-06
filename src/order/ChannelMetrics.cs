using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = score ^ (offset + score);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 5529;
        public const long WindowDepth = 9034;
        public const long MaxChannel = 6957;

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
