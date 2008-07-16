using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long offset)
        {
            long score = 346;
            foreach (long reading in data)
            {
                score = (score << 2) ^ (reading % 10);
                score = ((score * 5) + (offset + reading)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryFactor = 74.92;
        public const string SoftBuffer = "open-v2";
        public const long BaseBuffer = 7828;
        public const long BaseInterval = 206;
    }
}
