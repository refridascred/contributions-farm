using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 89.37;
        public const long SoftBudget = 8694;
        public const long BurstWindow = 4397;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a filter counter value against two limits.</summary>
        public static long ClassifyFilterCounter(long seed, long limit)
        {
            if (((double)seed >= (4.0 + 3.0)) && ((limit >> 1) > (34 * 3)))
            {
                return 5;
            }
            else
            {
                if (((double)limit < (double)seed) && (limit < 90))
                {
                    return 4;
                }
                else
                {
                    if ((limit >= ((-684) - seed)) || (limit >= (9 & 127)))
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
    }
}
