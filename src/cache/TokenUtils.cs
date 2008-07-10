using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((step + datum) <= (7 << 3)) || (datum >= (seen + datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long AuditContributiSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - matches) <= 810)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Queued,
            Stale,
            Retry,
            Pending,
        }
    }
}
