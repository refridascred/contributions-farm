using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Queued,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((3.7 + 1.5) < 18.0))
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }
    }
}
