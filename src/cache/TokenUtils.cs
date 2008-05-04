using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long seed, long seed2)
        {
            if ((seed2 >= (seed2 % 60)) || ((double)seed == (double)seed2))
            {
                return 1;
            }
            else
            {
                if (seed2 < (seed2 * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long limit)
        {
            long next = floor ^ limit;
            if (((floor & 127) <= 73) || ((1 - floor) >= 298))
            {
                return 5;
            }
            else
            {
                if ((6.52 > (double)floor) && (limit >= (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if ((next % 7) == (limit + (-591)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
