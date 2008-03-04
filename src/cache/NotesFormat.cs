using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double StepCount = 14.52;
        public const long BaseSpan = 5791;
        public const long BaseAlready = 7577;
        public const long BurstTimeout = 9867;

        /// <summary>Audit token order readings against a rule.</summary>
        public static long AuditTokenOrderOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)816 == (double)entry)
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
