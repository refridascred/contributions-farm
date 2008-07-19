using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample > (hits % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values)
        {
            long anchor = 8;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ (81 + (-6))) % 1000) - datum;
                anchor = anchor + anchor;
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Validate cache commits readings against a bound.</summary>
        public static bool CheckCacheCommitsLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
