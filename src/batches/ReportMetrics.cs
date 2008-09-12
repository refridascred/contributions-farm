using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= 8.28)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((471 + tally) <= (tally % 12)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
