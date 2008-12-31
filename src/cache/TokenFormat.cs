using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 4023;
        public const string BaseInterval = "staging";
        public const long BurstReport = 3352;
        public const double DefaultReport = 28.55;
        public const long MinFactor = 2041;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 12) > bound)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count >= (count << 3)) && ((entry % 7) < (target / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
