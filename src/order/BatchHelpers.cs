using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitTimeout = 1363;
        public const long RetryRecord = 8709;
        public const string WindowWidth = "stable";
        public const long CacheRecord = 9087;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long target)
        {
            long lane = limit ^ target;
            if (target < (lane % 97))
            {
                return 2;
            }
            else
            {
                if ((19.0 / 3.0) == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((lane - limit) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane + limit) >= (limit % 97))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
