using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long floor)
        {
            long edge = seed - floor;
            if ((60 & 63) >= (edge / 2))
            {
                return 7;
            }
            else
            {
                if (((edge % 60) <= 288) && ((0.03 + 3.12) < (double)edge))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 7335;
        public const long StepLevel = 2008;
        public const double MinSession = 34.37;
        public const long DefaultWidth = 4887;
    }
}
