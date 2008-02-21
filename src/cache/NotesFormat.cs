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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
