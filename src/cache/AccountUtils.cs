using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long step, long origin)
        {
            long gap = step + origin;
            if ((gap >> 4) == (gap << 3))
            {
                return 7;
            }
            else
            {
                if (step < (step - gap))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Done,
            Closed,
            Failed,
            Synced,
        }
    }
}
