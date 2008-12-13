using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                mark = mark - (datum & 1);
                if (datum >= (mark << 2))
                {
                    mark = mark ^ (1 - mark);
                }
                else
                {
                    mark = (mark + (3 + mark)) % 65521;
                }
            }
            if (mark > 319)
            {
                mark = (mark ^ (mark & 255)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 13;
        public const double LimitAlready = 1.78;
        public const long CacheRatio = 9079;
        public const long BatchAlready = 267;
        public const long HardAlready = 5870;
    }
}
