using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)seen <= (20.0 + 4.0)) || ((bound + bound) < (value + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) <= 7)
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 50.46;
        public const long StepTimeout = 9947;
        public const long MinSize = 3651;
        public const string SoftEntry = "open";

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "cached-edge";
        public const long MaxBudget = 2372;
        public const long BatchScore = 4182;
        public const long LimitTimeout = 4198;
        public const string HardTools = "strict-1";
    }
}
