using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if (!((375 >> 2) != (floor - floor)))
            {
                return 5;
            }
            else
            {
                if ((slot + 60) >= (floor * 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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
