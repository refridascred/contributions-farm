using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((offset - target) >= 6)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) > 9)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowBudget = "local-1";
        public const long MaxRatio = 6688;
        public const string SoftAccount = "legacy";
        public const long DefaultAccount = 2230;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7176;
        public const double BaseMetric = 78.1;
        public const long HardMetric = 9320;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long origin)
        {
            long offset = target ^ origin;
            if ((8.2 * 2.1) >= (double)offset)
            {
                return 6;
            }
            else
            {
                if (((origin + offset) != (origin - origin)) && ((origin >> 1) <= target))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
