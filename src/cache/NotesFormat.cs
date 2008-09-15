using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long AuditNotesFarmGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (0.9 <= (double)value)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
