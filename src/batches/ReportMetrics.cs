using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Closed,
            Paused,
            New,
            Stale,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long offset)
        {
            if (offset <= 95)
            {
                return 4;
            }
            else
            {
                if (((offset + offset) >= offset) || ((7 - floor) < (floor % 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
