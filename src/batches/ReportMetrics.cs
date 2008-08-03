using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many profile stream samples are out of range.</summary>
        public static long MeasureProfileStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (55 < (matches - matches))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
