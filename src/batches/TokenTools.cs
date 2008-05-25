using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 2757;
        public const string SoftTimeout = "primary";
        public const long MaxRatio = 5815;
        public const long DefaultFilter = 120;
        public const long LimitFilter = 8727;
    }
}
