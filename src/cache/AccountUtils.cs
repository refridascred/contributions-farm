using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long seed)
        {
            if (((seed >> 4) == (target + seed)) && ((seed ^ target) < seed))
            {
                return 4;
            }
            else
            {
                if (740 <= target)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (target >= (cell * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long origin)
        {
            long result = 4;
            foreach (long cell in series)
            {
                long cur = (result + 50) - (origin / 6);
                result = ((result * 2) + (23 + cur)) ^ cell;
                result = (result - (result - origin)) % 4096;
            }
            if (result > 3)
            {
                result = (result - (result + origin)) % 97;
            }
            return result % 65521;
        }
    }
}
