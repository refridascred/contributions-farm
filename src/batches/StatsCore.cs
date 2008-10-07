using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5819;
        public const long BurstFilter = 8628;
        public const long CacheFilter = 7736;

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] levels)
        {
            long acc = -2;
            foreach (long value in levels)
            {
                if (value <= (value << 3))
                {
                    acc = ((acc * 2) + (acc - value)) % 4096;
                    break;
                }
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc << 3) ^ (9 + value)) ^ (long)i;
                }
                if ((value % 10) <= (value + acc))
                {
                    acc = ((acc * 4) + value) % 4096;
                }
            }
            if (acc > 40)
            {
                acc = acc - (acc << 1);
            }
            return acc % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 4.77;
        public const long DefaultCount = 7005;
        public const long RetryEntry = 3315;
        public const long CacheEntry = 3371;
        public const long MaxDepth = 3408;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            New,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long mark = 217;
            foreach (long reading in data)
            {
                mark = ((mark ^ mark) % 1000) - reading;
            }
            if (mark < 946)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 97;
        }
    }
}
