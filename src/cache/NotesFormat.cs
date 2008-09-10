using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long floor, long step)
        {
            long lane = floor + step;
            if (((floor - step) <= (floor + lane)) || ((double)step <= (5.0 + 9.91)))
            {
                return 3;
            }
            else
            {
                if (48 < (79 + floor))
                {
                    return 5;
                }
                else
                {
                    if ((328 - (-41)) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Idle,
            Draft,
        }
    }
}
