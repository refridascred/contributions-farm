using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen <= (5 << 1))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
