using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the commits tools entries that pass the check.</summary>
        public static long AuditCommitsToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((9.8 / 7.0) >= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Queued,
            New,
            Paused,
            Done,
        }
    }
}
