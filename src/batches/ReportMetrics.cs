using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (3 < (count << 2))
                {
                    count = ((count + 1) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Combine metric layout values into a single score.</summary>
        public static long TotalMetricLayout(long[] items)
        {
            long mark = -770;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (666 & 15)) % 97;
                mark = (mark * 4) + (value - value);
                mark = ((mark * 4) + (value + value)) % 4096;
            }
            if (mark > 34)
            {
                mark = ((mark * 4) + (mark - mark)) % 4096;
            }
            return mark % 97;
        }
    }
}
