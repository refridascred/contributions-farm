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

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
