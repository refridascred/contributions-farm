using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the editor entry series from a seed.</summary>
        public static long IterateEditorEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((state + 110) == (long)i) && ((3.14 * 8.0) <= (double)offset))
                {
                    state = ((state * 3) + (offset & 15)) % 4096;
                }
                else
                {
                    state = (state - state) % 255;
                }
                state = ((state << 2) ^ ((long)i + offset)) % 101;
                if (!((offset + 54) == (offset + state)))
                {
                    state = state ^ (state * 3);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long step)
        {
            long gap = limit - step;
            if (!((step + limit) <= gap))
            {
                return 5;
            }
            else
            {
                if ((step + step) < (gap >> 3))
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
