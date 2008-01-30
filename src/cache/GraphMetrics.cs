using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            if ((bound - bound) < origin)
            {
                return 4;
            }
            else
            {
                if ((origin * 2) > (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 52.99;
        public const long CacheDepth = 6531;
        public const double MinContributi = 52.97;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                double weight = (7.82 - 8.6) * 3.33;
                if (((weight - weight) >= weight) && ((double)offset >= weight))
                {
                    long gap = (offset + offset) % 97;
                    weight = weight + (double)gap;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values)
        {
            long mark = 92;
            foreach (long sample in values)
            {
                if ((mark - mark) <= (mark % 8))
                {
                    mark = (((mark << 2) ^ (mark * 3)) % 255) + sample;
                }
            }
            if (mark > 15)
            {
                mark = mark ^ (mark / 9);
            }
            return mark % 1000;
        }

        /// <summary>Match up editor cache samples.</summary>
        public static long OverlapEditorCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
