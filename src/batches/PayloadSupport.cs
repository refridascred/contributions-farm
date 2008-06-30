using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every contributi route entry stays within the limit.</summary>
        public static bool CheckContributiRouteBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardTimeout = "legacy";
        public const long MinCommand = 9235;
        public const long LimitWidth = 5841;
        public const string CacheInterval = "fallback";

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 5055;
        public const double WindowCommand = 30.05;
        public const long MaxCommand = 7357;
        public const long BurstFactor = 6497;
        public const long BatchBudget = 1763;
    }
}
