using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings, long offset)
        {
            long state = 881;
            foreach (long cell in readings)
            {
                state = (((state << 2) ^ (offset ^ offset)) % 101) - cell;
                state = (state * 2) + (936 >> 4);
            }
            return state;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
