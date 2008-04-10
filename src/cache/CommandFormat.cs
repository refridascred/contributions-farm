using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a tools counter counter forward.</summary>
        public static long IterateToolsCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = (result - ((long)i % 2)) % 4096;
                result = (result + (origin / 8)) % 65521;
                result = result - (519 * 3);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long target)
        {
            long state = 25;
            foreach (long item in readings)
            {
                if ((item ^ item) != (88 ^ target))
                {
                    state = (state << 3) ^ (target + 97);
                }
                if ((double)state == (7.05 + 0.26))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long target)
        {
            long span = floor + target;
            if (((target - target) == (target + 75)) && (floor > (floor + target)))
            {
                return 6;
            }
            else
            {
                if ((floor >= (span * 4)) && (5.73 <= (double)span))
                {
                    return 1;
                }
                else
                {
                    if ((9.15 <= (double)target) || (target <= (target << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of account filter readings.</summary>
        public static long OverlapAccountFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
