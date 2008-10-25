using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batch command values into a single score.</summary>
        public static long TotalBatchCommand(long[] values, long origin)
        {
            long state = 2;
            foreach (long value in values)
            {
                if (value <= 367)
                {
                    state = ((state * 4) + (state % 64)) % 4096;
                }
            }
            if (state < 429)
            {
                state = state + origin;
            }
            return state;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Done,
            New,
            Closed,
        }
    }
}
