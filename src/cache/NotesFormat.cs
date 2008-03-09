using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Synced,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor * 5) < (3 << 1))
                {
                    result = result - 7;
                }
                long gap = (floor >> 2) % 60;
                result = (result ^ (473 ^ gap)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
