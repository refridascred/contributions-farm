using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + value) != (value * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Closed,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Dropped,
            New,
            Retry,
            Idle,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
