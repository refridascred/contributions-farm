using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long anchor = 361;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 5) + (cell / 7)) % 1000;
            }
            if (anchor < 4)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Draft,
            Retry,
            Pending,
            Done,
        }
    }
}
