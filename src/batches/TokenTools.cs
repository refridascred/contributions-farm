using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Draft,
            Idle,
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
