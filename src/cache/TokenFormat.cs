using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long seed)
        {
            long cur = offset ^ seed;
            if ((double)offset >= 7.9)
            {
                return 4;
            }
            else
            {
                if (((16.0 + 4.6) == (double)seed) || (295 >= (offset % 7)))
                {
                    return 6;
                }
                else
                {
                    if (cur >= (offset & 15))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
