using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + origin) >= (hits / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
