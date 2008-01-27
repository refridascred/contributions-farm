using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 7087;
        public const long CacheCount = 6135;
        public const long CacheBudget = 5614;
        public const string RetryCounter = "primary-edge";

        /// <summary>Audit tools buffer readings against a rule.</summary>
        public static long CountToolsBufferGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!((27 ^ 5) <= limit))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double rate = offset;
            if (rate >= (rate * 4.45))
            {
                rate = (rate - (offset + rate)) - gain;
            }
            return rate + (18.0 * 4.0);
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
