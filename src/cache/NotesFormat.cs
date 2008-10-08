using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 10.18;
        public const long StepWidth = 656;
        public const long CacheStream = 680;

        /// <summary>Rank account graph input into a small class.</summary>
        public static long SortAccountGraph(long floor, long seed)
        {
            if ((floor & 31) <= (seed + seed))
            {
                return 7;
            }
            else
            {
                if (!((seed / 7) < (floor + 842)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
