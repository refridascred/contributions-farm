using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowCount = 99.0;
        public const string BatchBatches = "open";
        public const long CacheBudget = 6153;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long limit2)
        {
            if (limit2 >= 6)
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (4.07 + 14.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Closed,
            Queued,
        }
    }
}
