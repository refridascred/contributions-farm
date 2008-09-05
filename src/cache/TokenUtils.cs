using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool CheckFarmGraphLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long CountContributiCacheMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length >= (double)hits)
                {
                    hits = ((hits + 2) - value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6087;
        public const long LimitScore = 1762;
        public const long SoftSize = 8257;
        public const double HardDepth = 52.24;
        public const long DefaultSize = 3370;
    }
}
