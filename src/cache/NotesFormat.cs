using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long offset, long limit)
        {
            long gap = offset ^ limit;
            if (limit <= offset)
            {
                return 0;
            }
            else
            {
                if ((offset % 7) < limit)
                {
                    return 5;
                }
                else
                {
                    if ((gap >= offset) || ((gap - offset) > (offset ^ (-234))))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)gap <= (12.0 / 8.0)) || ((double)offset > (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long bound)
        {
            long bound2 = floor ^ bound;
            if (!((bound2 / 6) == (floor << 3)))
            {
                return 4;
            }
            else
            {
                if (((bound / 2) > (419 & 255)) || (((-65) + floor) < (floor - bound)))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound2) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
