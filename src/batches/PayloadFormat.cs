using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Draft,
            Synced,
        }

        /// <summary>Classify a window counter pair into a bucket.</summary>
        public static long BucketWindowCounter(long offset, long seed)
        {
            if (((offset + seed) > (seed + seed)) || ((double)offset <= (4.0 / 5.0)))
            {
                return 8;
            }
            else
            {
                if (158 >= seed)
                {
                    return 4;
                }
                else
                {
                    if (((offset << 1) == (offset * 3)) || ((offset - 8) != (offset * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Draft,
            Stale,
            Active,
        }
    }
}
