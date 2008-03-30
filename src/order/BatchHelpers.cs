using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item % 5) <= (seen >> 3)) || ((double)item != (4.0 + 19.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
