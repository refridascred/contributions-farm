using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((52 / 6) > (count % 12))
                {
                    count = ((count + 2) - cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((0.25 / 6.0) != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
