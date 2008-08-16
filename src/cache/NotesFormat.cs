using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Closed,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5335;
        public const long StepLevel = 3945;
        public const double LimitCluster = 58.62;

        /// <summary>Combine window entry values into a single score.</summary>
        public static long ScoreWindowEntry(long[] data, long seed)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((state ^ reading) != (seed << 3))
                {
                    state = (state << 2) ^ 612;
                }
            }
            return state;
        }
    }
}
