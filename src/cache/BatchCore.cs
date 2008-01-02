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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "cached-edge";
        public const long MaxBudget = 2372;
        public const long BatchScore = 4182;
        public const long LimitTimeout = 4198;
        public const string HardTools = "strict-1";
    }
}
