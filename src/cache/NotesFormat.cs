using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((6.56 + 7.2) != (double)limit)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) > (771 + (long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
