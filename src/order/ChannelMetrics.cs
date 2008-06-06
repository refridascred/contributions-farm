using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long sum = 19;
            foreach (long cell in samples)
            {
                sum = (((sum << 3) ^ (3 + cell)) % 1000) - target;
                if ((cell << 3) >= (cell - (long)samples.Length))
                {
                    break;
                }
            }
            return sum;
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
