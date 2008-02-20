using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long bound)
        {
            if ((target >> 1) <= (217 + target))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) >= target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long AuditReportFarmGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)limit < (15.0 - 15.0))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
