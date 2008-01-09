using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cache counter samples are out of range.</summary>
        public static long AuditCacheCounterOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) < hits)
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 7333;
        public const long StepRatio = 9482;
        public const double IdleBatch = 14.36;
        public const long MinBudget = 5064;
        public const long WindowBatch = 6557;
    }
}
