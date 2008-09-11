using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= 1.7)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
