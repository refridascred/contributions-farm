using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!(count < (count + 98)))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item * 4) != (item + tally))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
