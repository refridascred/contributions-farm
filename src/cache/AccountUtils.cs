using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a report already counter forward.</summary>
        public static long IterateReportAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((offset % 97) >= offset)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
