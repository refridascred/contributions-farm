using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values)
        {
            long sum = 59;
            foreach (long cell in values)
            {
                if ((cell ^ cell) == (sum % 100))
                {
                    sum = ((sum << 3) ^ (cell / 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 63) == (count / 4))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
