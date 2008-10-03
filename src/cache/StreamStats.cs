using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6588;
        public const double MinTimeout = 27.54;
        public const double BurstReport = 38.04;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches != (3.6 * 1.32))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
