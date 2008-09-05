using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((1.6 - 1.0) < (double)(long)levels.Length) || (((19.0 - 5.4) <= (double)count) && ((datum ^ count) >= 77)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (!((delta << 2) <= (limit2 * 4)))
            {
                return 4;
            }
            else
            {
                if ((9.14 * 5.0) >= (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if ((delta << 1) < 804)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit >= (6.03 / 6.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((20.0 <= (double)cell) || !((cell * 2) <= (917 % 64)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
