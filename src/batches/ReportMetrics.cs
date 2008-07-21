using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long TallySchemaNotesGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen * 2) >= step)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
