using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + seen) > (target << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
