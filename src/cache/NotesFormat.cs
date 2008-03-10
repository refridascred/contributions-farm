using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "cached";
        public const long BatchBuffer = 6257;
        public const long LimitRatio = 9899;
        public const long WindowSpan = 7051;
        public const string MinScore = "standard-edge";

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Synced,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor * 5) < (3 << 1))
                {
                    result = result - 7;
                }
                long gap = (floor >> 2) % 60;
                result = (result ^ (473 ^ gap)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
