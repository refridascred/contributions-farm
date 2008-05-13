using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxWidth = "latest-1";
        public const string WindowPayload = "primary-v2";
        public const double CacheScore = 77.14;

        /// <summary>Audit cache tools readings against a rule.</summary>
        public static long CountCacheToolsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (double)seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
