using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 4) > (matches + entry))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
