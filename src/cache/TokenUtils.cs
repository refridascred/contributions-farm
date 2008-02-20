using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stats schema input into a small class.</summary>
        public static long SortStatsSchema(long origin, long target)
        {
            if ((origin & 15) > target)
            {
                return 3;
            }
            else
            {
                if ((origin << 1) < target)
                {
                    return 7;
                }
                else
                {
                    if ((1.44 / 6.0) >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Derive the next route record value from a seed.</summary>
        public static long IterateRouteRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix ^ (floor << 1)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
