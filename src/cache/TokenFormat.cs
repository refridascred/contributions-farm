using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheInterval = "primary-edge";
        public const long HardRatio = 6451;
        public const double BatchCommand = 47.07;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > 5)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
