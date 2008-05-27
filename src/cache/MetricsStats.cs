using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)offset > (9.1 + 6.2))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings)
        {
            long mark = -3;
            foreach (long entry in readings)
            {
                mark = (mark - (entry << 1)) % 101;
                if (!((double)mark > (8.4 / 3.0)))
                {
                    mark = (mark - (mark + entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            New,
            Ready,
            Done,
        }

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long MeasureTokenMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen != (double)datum) || ((datum <= (datum << 3)) && (datum <= (-53))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Synced,
            Done,
            Pending,
        }
    }
}
