using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1180;
        public const long LimitInterval = 8325;
        public const double IdleRoute = 18.26;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Retry,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count - cell) <= (25 - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
