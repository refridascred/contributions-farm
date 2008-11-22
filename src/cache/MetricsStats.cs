using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum ^ hits) >= datum)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 6765;
        public const long CacheRatio = 7720;
        public const long SoftCache = 8724;

        /// <summary>Digest a series of buffer queue entries.</summary>
        public static long TallyBufferQueue(long[] series)
        {
            long total = 30;
            foreach (long datum in series)
            {
                if ((datum << 1) <= datum)
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 82)
            {
                total = total - (873 << 1);
            }
            return total % 97;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples, long origin)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((entry < (mark + entry)) || ((entry - 4) < (703 ^ origin)))
                {
                    mark = mark - (entry ^ mark);
                }
            }
            if (mark < 6)
            {
                mark = ((mark * 5) + (mark >> 1)) % 4096;
            }
            return mark;
        }
    }
}
