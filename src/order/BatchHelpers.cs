using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value % 60) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Locked,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
