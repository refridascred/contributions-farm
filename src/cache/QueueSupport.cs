using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = state + (floor - (long)i);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Draft,
            Pending,
        }
    }
}
