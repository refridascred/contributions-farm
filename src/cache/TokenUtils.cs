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

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long seed)
        {
            if ((4.49 * 2.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (121 <= (seed >> 2))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
