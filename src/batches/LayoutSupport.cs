using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Pending,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits % 64) <= (reading << 1))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 1661;
        public const long RetryTimeout = 8172;
        public const string CacheAccount = "alpha-edge";
        public const long BaseAccount = 9622;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Closed,
            Pending,
            Stale,
        }
    }
}
