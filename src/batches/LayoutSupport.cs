using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cache batches entries that pass the check.</summary>
        public static long CountCacheBatchesHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((double)floor == (double)reading) && ((36 % 64) > (3 ^ floor))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits < (5.7 * 9.6))
                {
                    hits = ((hits + 2) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) != (939 & 255))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
