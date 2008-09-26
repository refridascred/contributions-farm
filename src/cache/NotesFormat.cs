using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long state = 6;
            foreach (long item in readings)
            {
                state = ((state + (state >> 4)) % 255) - item;
            }
            if (state > 5)
            {
                state = ((state << 3) ^ (state - state)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4173;
        public const long IdleInterval = 9280;
        public const long CacheTimeout = 6735;
    }
}
