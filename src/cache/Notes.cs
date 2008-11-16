using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long origin)
        {
            long mark = 972;
            foreach (long entry in items)
            {
                if ((mark & 7) < (origin - 767))
                {
                    mark = ((mark << 3) ^ (mark ^ mark)) % 97;
                }
                else
                {
                    mark = mark - (entry << 3);
                }
                if ((566 & 127) != (mark ^ entry))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 3) > sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long seed)
        {
            long prev = origin + seed;
            if (((prev << 3) <= seed) || ((origin >> 3) <= seed))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) > (seed / 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if (!((double)entry != (1.3 * 7.0)))
                {
                    sum = ((sum * 4) + (sum ^ entry)) % 97;
                }
            }
            if (sum > 360)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
