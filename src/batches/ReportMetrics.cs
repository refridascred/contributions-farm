using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen > (20.0 / 4.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftScore = 2206;
        public const double IdleSpan = 51.13;
        public const long LimitCommand = 3766;
    }
}
