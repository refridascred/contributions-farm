using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepCount = 7814;
        public const double SoftBatches = 80.39;
        public const long MaxBatches = 2073;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long floor)
        {
            long gap = origin - floor;
            if ((3.84 - 6.38) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + gap) == (gap + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (gap - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
