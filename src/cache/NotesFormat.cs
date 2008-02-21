using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Locked,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardTimeout = 4091;
        public const long WindowSpan = 7845;
        public const long HardCounter = 255;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((cell - cell) <= (cell ^ cell)) || ((double)cell < (2.45 - 13.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
