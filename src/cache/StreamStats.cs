using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long MeasureSessionEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((8.3 * 16.0) >= (double)item) || ((seen << 1) != (seen % 64)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            Active,
            Done,
            Synced,
        }

        /// <summary>Grade a account channel value against two limits.</summary>
        public static long ClassifyAccountChannel(long origin, long origin2)
        {
            long offset = origin + origin2;
            if ((18 + origin) < (offset - origin))
            {
                return 4;
            }
            else
            {
                if ((606 << 3) >= (origin / 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Ready,
            Active,
            Stale,
        }
    }
}
