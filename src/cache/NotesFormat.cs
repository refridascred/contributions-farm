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

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long seed)
        {
            if ((double)floor > (double)24)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (double)186)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
