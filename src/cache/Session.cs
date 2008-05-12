using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6275;
        public const double HardQueue = 32.43;
        public const double LimitQueue = 77.13;
        public const long MinRatio = 1551;

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long floor)
        {
            long slot = offset + floor;
            if (slot <= offset)
            {
                return 0;
            }
            else
            {
                if ((double)slot > (9.23 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((floor + offset) != (offset + offset)) || ((offset + slot) != (floor + floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long seed)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (total <= (item / 5))
                {
                    total = total - (total + total);
                }
                else
                {
                    total = (total + (seed >> 1)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9029;
        public const double WindowScore = 98.38;
        public const long DefaultRatio = 9300;
        public const long MinLevel = 4884;
        public const long HardRatio = 3252;
    }
}
