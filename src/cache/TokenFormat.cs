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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long seed)
        {
            long edge = target + seed;
            if ((seed + edge) <= (seed & 31))
            {
                return 0;
            }
            else
            {
                if ((seed << 3) > (seed - edge))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (0.47 + 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
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
