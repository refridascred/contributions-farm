using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            New,
            Retry,
            Closed,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Pending,
            Stale,
            Synced,
            New,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
