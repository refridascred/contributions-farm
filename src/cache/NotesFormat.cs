using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            if ((origin >> 4) < (offset & 3))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) >= 6)
                {
                    return 2;
                }
                else
                {
                    if ((6.0 * 8.37) == (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ seed) <= seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
