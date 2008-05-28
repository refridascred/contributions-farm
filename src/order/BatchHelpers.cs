using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long state = 7;
            foreach (long cell in items)
            {
                if (((cell + state) >= (cell & 3)) && ((cell + state) > state))
                {
                    state = state - state;
                }
                else
                {
                    state = (state ^ (cell + cell)) % 4096;
                }
            }
            if (state > 138)
            {
                state = (state + (state - (-11))) % 255;
            }
            return state % 1000;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Done,
            New,
        }
    }
}
