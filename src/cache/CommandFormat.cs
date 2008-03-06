using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Idle,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 3) ^ sum) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
