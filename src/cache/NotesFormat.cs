using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
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
