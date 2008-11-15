using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count >> 1) > (floor & 63))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Locked,
            Closed,
            Failed,
        }
    }
}
