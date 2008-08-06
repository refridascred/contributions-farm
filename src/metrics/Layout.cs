using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target > (state % 60)) || ((state * 5) < target))
                {
                    state = (state * 3) + target;
                    state = state + target;
                }
                if ((target << 1) >= 35)
                {
                    state = state ^ (state - target);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the batches tools entries that pass the check.</summary>
        public static long AuditBatchesToolsGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((20.0 <= (double)item) || (seed < (95 - (long)readings.Length)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format route sample.</summary>
        public static long LocateFormatRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
