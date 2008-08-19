using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                anchor = ((anchor + (step ^ anchor)) % 1000) + item;
            }
            return anchor;
        }

        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long CountOrderChannelOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((matches << 3) > 156) && ((matches + datum) < (datum / 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
