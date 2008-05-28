using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long offset)
        {
            if (offset < (offset - bound))
            {
                return 8;
            }
            else
            {
                if ((bound / 2) >= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((16.0 / 9.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - offset) <= (offset << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "staging-edge";
        public const long BatchBudget = 6295;
        public const long DefaultCount = 9914;
        public const long MaxStream = 3133;
        public const long BaseStream = 4731;

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell % 16) >= 73)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
