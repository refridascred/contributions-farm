using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long AuditProfileCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (1.79 - 1.61))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Failed,
            Retry,
            Synced,
            Queued,
        }
    }
}
