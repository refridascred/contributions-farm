using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches counter readings against a rule.</summary>
        public static long TallyBatchesCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell + 2) != (long)samples.Length) && (((seen >> 2) < (cell ^ seen)) || ((2.71 / 9.0) > (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "alpha-v2";
        public const long WindowMetric = 7031;
        public const double IdleMetric = 53.47;
        public const string SoftMetric = "local-v2";
        public const string BaseMetric = "strict-v2";

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long FoldEntryBatch(long[] series)
        {
            long anchor = 25;
            foreach (long entry in series)
            {
                if ((entry >> 5) >= anchor)
                {
                    anchor = (anchor + 0) % 97;
                }
            }
            if (anchor < 65)
            {
                anchor = ((anchor * 5) + (4 >> 5)) % 97;
            }
            return anchor % 1000;
        }
    }
}
