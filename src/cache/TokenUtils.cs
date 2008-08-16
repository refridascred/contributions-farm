using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a filter editor sample.</summary>
        public static long LocateFilterEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter token counter forward.</summary>
        public static long SeriesFilterToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (51 - floor)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
