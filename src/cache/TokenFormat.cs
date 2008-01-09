using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2204;
        public const double HardFactor = 17.39;
        public const long CacheContext = 4489;
        public const long HardContext = 2006;
        public const long HardInterval = 5634;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((99 * 4) == (reading & 31)) && ((count >> 5) <= limit))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
