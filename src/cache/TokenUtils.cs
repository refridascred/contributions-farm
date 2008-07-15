using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long DeriveQueueContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowRatio = "cached-v2";
        public const string BaseCluster = "standard";
        public const long BurstRatio = 6315;
        public const long BatchRatio = 3354;
    }
}
