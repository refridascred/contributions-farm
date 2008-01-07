using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long SeriesStreamNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Pending,
            Stale,
            Dropped,
            Queued,
        }
    }
}
