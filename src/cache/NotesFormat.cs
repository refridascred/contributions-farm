using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((43 & 15) <= item)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Count the editor checks entries that pass the check.</summary>
        public static long AuditEditorChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)(long)series.Length > (double)value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
