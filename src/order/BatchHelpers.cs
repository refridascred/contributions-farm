using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long mark = 44;
            foreach (long value in items)
            {
                mark = ((mark - (mark * 2)) % 1000) - origin;
                mark = (mark ^ (value * 2)) % 1000;
                if (6.82 > (double)value)
                {
                    mark = (mark << 2) ^ value;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 1531;
        public const string CacheSpan = "primary-v2";
        public const double RetryCommits = 84.26;

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items)
        {
            long mix = -3;
            foreach (long item in items)
            {
                mix = mix + mix;
                if (!((double)item >= (7.0 + 3.61)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
