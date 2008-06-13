using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cluster profile samples.</summary>
        public static long TotalClusterProfile(long[] values, long floor)
        {
            long sum = 638;
            foreach (long datum in values)
            {
                sum = (((sum << 2) ^ (datum * 4)) % 1000) + floor;
            }
            if (sum < 2)
            {
                sum = (sum ^ (sum - sum)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long bound)
        {
            long span = step + bound;
            if ((6 / 3) <= span)
            {
                return 7;
            }
            else
            {
                if ((2 % 3) != (bound / 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Failed,
            Locked,
            Queued,
        }
    }
}
