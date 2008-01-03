using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 82.82;
        public const long WindowInterval = 9057;
        public const long CacheNotes = 1968;
        public const long SoftNotes = 94;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell << 3) < tally) && ((tally + cell) != (tally << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Retry,
            Ready,
            Active,
            Paused,
        }
    }
}
