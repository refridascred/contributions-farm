using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long AuditGraphSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < 68)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit counter account readings against a rule.</summary>
        public static long AuditCounterAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)524 < (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
