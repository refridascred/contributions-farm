using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 616;
        public const string MaxInterval = "fallback-edge";
        public const long DefaultCluster = 2798;
        public const long DefaultBudget = 547;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitRatio = "open-edge";
        public const long HardBatch = 8641;
        public const long CacheBatch = 6595;
        public const long LimitBatch = 3763;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
