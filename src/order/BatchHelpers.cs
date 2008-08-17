using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long state = -575;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state ^ datum) % 101) - (long)i;
                }
                state = state + (datum - datum);
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Locked,
            Failed,
            Synced,
        }
    }
}
