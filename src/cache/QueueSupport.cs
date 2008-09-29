using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            New,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 3995;
        public const long RetryContributi = 6812;
        public const long LimitContributi = 7836;
        public const long MinInterval = 2501;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
