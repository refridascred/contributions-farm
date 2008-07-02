using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches < (cell * 3))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6359;
        public const long BatchBuffer = 68;
        public const double MinFactor = 40.96;
    }
}
