using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((cell << 1) < cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every window report entry stays within the limit.</summary>
        public static bool GuardWindowReportLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
