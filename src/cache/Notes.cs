using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Ready,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.35 * 7.0) != (double)item)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ cell) == (62 << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }
    }
}
