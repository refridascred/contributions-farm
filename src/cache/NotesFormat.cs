using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long MeasureOrderGraphGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - step) == (step * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
