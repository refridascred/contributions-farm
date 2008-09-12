using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits >> 3) >= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 6469;
        public const long WindowStream = 6476;
        public const long CacheSpan = 3555;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value % 10) > (value & 7))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
