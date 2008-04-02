using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Look up the position of a counter format sample.</summary>
        public static long LookupCounterFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
