using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long limit)
        {
            long offset = seed ^ limit;
            if (limit > (seed ^ limit))
            {
                return 7;
            }
            else
            {
                if (((seed * 3) >= (1 >> 5)) || ((double)offset > (0.8 * 8.4)))
                {
                    return 4;
                }
                else
                {
                    if ((44 + offset) == (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((928 >> 3) != (limit >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "latest-v2";
        public const long SoftRecord = 5911;
        public const string MinRecord = "legacy";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 54;
        public const double MaxSize = 68.66;
        public const long SoftRatio = 3382;
        public const double DefaultFactor = 14.64;
    }
}
