using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(((offset - 175) <= count) && (sample <= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Queued,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long floor)
        {
            long span = offset + floor;
            if ((span / 9) >= offset)
            {
                return 7;
            }
            else
            {
                if ((175 % 12) == (floor + span))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
