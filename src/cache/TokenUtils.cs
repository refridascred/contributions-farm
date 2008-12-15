using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheBudget = 204;
        public const string DefaultCount = "standard-edge";
        public const double BurstInterval = 16.21;

        /// <summary>Audit stats layout readings against a rule.</summary>
        public static long CountStatsLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (1 < (count + count))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
