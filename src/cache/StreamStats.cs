using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long bound)
        {
            long sum = -29;
            foreach (long entry in levels)
            {
                sum = ((sum << 2) ^ (bound / 9)) + entry;
            }
            return sum;
        }

        /// <summary>Validate farm editor readings against a bound.</summary>
        public static bool CheckFarmEditorRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Retry,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "latest";
        public const string MaxOrder = "primary-edge";
        public const double IdleOrder = 97.32;
        public const long MinWidth = 657;
    }
}
