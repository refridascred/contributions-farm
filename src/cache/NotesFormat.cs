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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) < ((long)values.Length / 4))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
