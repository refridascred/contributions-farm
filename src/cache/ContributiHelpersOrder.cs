using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Closed,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] items)
        {
            long anchor = -108;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell & 7)) % 1000;
            }
            return anchor;
        }
    }
}
