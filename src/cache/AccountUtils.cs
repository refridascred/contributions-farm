using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long limit2)
        {
            if ((limit2 & 31) != (limit2 ^ limit2))
            {
                return 2;
            }
            else
            {
                if ((limit2 < (limit - limit2)) || (3.15 > (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 5720;
        public const long MinFactor = 7266;
        public const long IdleBatch = 3075;
        public const double HardBatch = 25.94;

        /// <summary>Accumulate support stats samples.</summary>
        public static long DigestSupportStats(long[] levels, long floor)
        {
            long sum = 64;
            foreach (long reading in levels)
            {
                sum = (((sum - (-2)) % 97) - reading) + floor;
            }
            return sum % 1000;
        }
    }
}
