using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long state = 671;
            foreach (long cell in readings)
            {
                state = (state - (cell << 3)) % 101;
            }
            return state;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
