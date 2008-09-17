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

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data, long seed)
        {
            long total = 3;
            foreach (long value in data)
            {
                total = (total ^ (769 << 3)) - value;
            }
            if (total > (-33))
            {
                total = (total + (seed % 100)) % 97;
            }
            return total;
        }

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
