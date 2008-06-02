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

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 7579;
        public const long BurstWidth = 3955;
        public const long BaseSpan = 3204;
        public const string LimitBatch = "alpha";
    }
}
