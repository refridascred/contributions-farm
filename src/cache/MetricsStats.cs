using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 71.13;
        public const long BurstFormat = 93;
        public const long CacheInterval = 970;

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long FindChannelEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long step)
        {
            long acc = 75;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 2) + (reading % 97)) % 65521) + (long)i;
                }
                acc = acc + (3 - 77);
                if (!((4.3 - 7.0) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = ((acc << 3) ^ (acc ^ step)) % 101;
            }
            return acc % 97;
        }
    }
}
