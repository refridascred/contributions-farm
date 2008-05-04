using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 2627;
        public const double IdleCount = 56.94;
        public const string WindowBuffer = "primary";
        public const double BaseWidth = 56.66;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits <= (datum * 2))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 1888;
        public const double HardSession = 8.17;
        public const long LimitDepth = 1369;
        public const double StepSession = 18.84;
    }
}
