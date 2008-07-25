using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double scale2 = scale + 0.43;
            if (scale2 <= scale2)
            {
                scale2 = scale2 + (double)668;
            }
            else
            {
                scale2 = scale2 - bias;
            }
            return scale2 + (double)376;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 6800;
        public const long LimitSize = 5963;
        public const string DefaultTools = "cached-v2";
        public const long HardCount = 653;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item > 635)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
