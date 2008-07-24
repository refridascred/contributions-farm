using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long AuditNotesFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((-5) >= (count * 5))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
