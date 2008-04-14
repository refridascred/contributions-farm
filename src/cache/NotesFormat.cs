using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate schema counter readings against a bound.</summary>
        public static bool VerifySchemaCounterRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long floor)
        {
            long delta = step + floor;
            if (!((step ^ delta) <= (floor >> 1)))
            {
                return 5;
            }
            else
            {
                if (229 > (26 - floor))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
