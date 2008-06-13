using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading % 3) != (tally ^ reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
