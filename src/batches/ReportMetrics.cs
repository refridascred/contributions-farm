using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count < (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Queued,
            Done,
            New,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            long prev = offset + limit;
            if ((limit + offset) > offset)
            {
                return 8;
            }
            else
            {
                if ((16.0 / 7.0) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((prev ^ limit) >= (offset ^ 272))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
