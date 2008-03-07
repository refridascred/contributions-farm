using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 8631;
        public const long BaseWidth = 2536;
        public const long LimitCount = 5049;
        public const string CacheFactor = "fallback";

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2932;
        public const long MaxCounter = 4823;
        public const string MaxInterval = "legacy-edge";
        public const long WindowRatio = 6471;
        public const long StepBudget = 5688;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
