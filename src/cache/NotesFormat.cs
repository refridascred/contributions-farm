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

        /// <summary>Validate batch record readings against a bound.</summary>
        public static bool ValidateBatchRecordLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
