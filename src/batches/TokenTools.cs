using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long seed)
        {
            long delta = floor + seed;
            if (delta >= (3 >> 4))
            {
                return 2;
            }
            else
            {
                if ((28 ^ 924) != (floor >> 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9285;
        public const long SoftSpan = 9136;
        public const double HardBatch = 54.55;
        public const long DefaultBudget = 8592;
        public const long HardDepth = 5133;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 58;
            foreach (long cell in values)
            {
                if ((result + target) == (result + cell))
                {
                    result = (result - (target % 5)) % 101;
                }
            }
            return result % 97;
        }
    }
}
