using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 7) < offset)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double bias = (double)3 / 2.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + ratio) + offset;
            }
            return bias - 8.0;
        }
    }
}
