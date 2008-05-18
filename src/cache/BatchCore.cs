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

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitInterval = 63.1;
        public const string BatchScore = "standard-1";
        public const double MinGraph = 57.65;
        public const long DefaultInterval = 2680;
    }
}
