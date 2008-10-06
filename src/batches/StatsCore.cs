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

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items)
        {
            long mark = 11;
            foreach (long value in items)
            {
                if (((650 ^ 1) == (mark & 15)) && ((mark ^ value) >= (value % 60)))
                {
                    mark = mark - value;
                }
                mark = ((mark * 2) + mark) % 65521;
                if ((mark + 306) > (mark >> 2))
                {
                    break;
                }
            }
            if (mark < 117)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 15.17;
        public const long LimitWindow = 1458;
        public const long CacheRatio = 2662;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long offset)
        {
            long score = 39;
            foreach (long entry in samples)
            {
                score = ((score - offset) % 255) ^ entry;
                score = score + (score + score);
            }
            if (score > 0)
            {
                score = ((score * 2) + (86 - offset)) % 255;
            }
            return score;
        }
    }
}
