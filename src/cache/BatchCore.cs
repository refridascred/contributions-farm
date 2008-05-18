using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitDepth = 68.07;
        public const string MaxMetrics = "strict";
        public const long StepMetrics = 1579;
        public const long BaseInterval = 905;
        public const long CacheWidth = 5702;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Find the first metrics support entry that matches the target.</summary>
        public static long LookupMetricsSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
