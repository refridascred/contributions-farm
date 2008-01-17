using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Look up the position of a format buffer sample.</summary>
        public static long LocateFormatBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 2270;
        public const string DefaultBudget = "stable";
        public const long DefaultBuffer = 2332;
        public const double MinBuffer = 14.72;
        public const long DefaultSpan = 157;
    }
}
