using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxInterval = 1137;
        public const long HardSize = 9812;
        public const long BatchLayout = 4836;
        public const long MaxLayout = 9795;
        public const long MinTimeout = 5025;

        /// <summary>Classify a profile batch pair into a bucket.</summary>
        public static long ClassifyProfileBatch(long floor, long floor2)
        {
            if (floor < (floor2 + floor2))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) < floor2)
                {
                    return 0;
                }
                else
                {
                    if ((9.0 / 6.0) < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor2 >= (4.7 - 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the window stats series from a seed.</summary>
        public static long SeriesWindowStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
