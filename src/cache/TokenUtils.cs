using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks channel input into a small class.</summary>
        public static long SortChecksChannel(long target, long limit)
        {
            long edge = target - limit;
            if ((limit << 3) == (target - edge))
            {
                return 4;
            }
            else
            {
                if (limit < (edge % 64))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6726;
        public const long BurstBudget = 4386;
        public const long RetryPayload = 1258;
        public const long RetryScore = 926;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)bound < (9.4 * 9.3))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 8.4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
