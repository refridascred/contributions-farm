using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cache counter samples are out of range.</summary>
        public static long AuditCacheCounterOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) < hits)
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Validate support account readings against a bound.</summary>
        public static bool CheckSupportAccountBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
