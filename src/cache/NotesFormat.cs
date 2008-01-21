using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long CountEditorCounterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) <= (reading & 31))
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

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (limit > (limit - bound))
            {
                return 0;
            }
            else
            {
                if (!((double)limit >= 6.4))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (-46))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Synced,
            Paused,
            Locked,
            Done,
        }
    }
}
