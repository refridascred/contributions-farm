using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftLevel = 617;
        public const long MinContext = 5279;
        public const double HardBudget = 93.94;
        public const double HardContext = 7.8;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long origin2)
        {
            if (((origin2 & 1) < origin2) && ((double)origin2 < 20.0))
            {
                return 3;
            }
            else
            {
                if ((double)origin2 <= (6.08 - 9.62))
                {
                    return 6;
                }
                else
                {
                    if (((origin - origin2) >= (origin + origin2)) || ((double)origin >= (7.7 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}
