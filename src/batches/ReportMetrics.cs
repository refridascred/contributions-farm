using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstBudget = 5385;
        public const long IdleCount = 8468;
        public const long RetryBudget = 5465;
        public const double BatchSchema = 81.48;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long offset, long bound)
        {
            long prev = offset - bound;
            if ((bound * 2) >= (5 * 4))
            {
                return 4;
            }
            else
            {
                if (prev > (offset % 24))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long target)
        {
            long diff = floor ^ target;
            if (target > 61)
            {
                return 2;
            }
            else
            {
                if ((20.0 + 6.2) == (double)diff)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
