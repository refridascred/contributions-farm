using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(reading > (tally % 16)))
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Active,
            Stale,
            Queued,
            Ready,
        }
    }
}
