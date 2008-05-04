using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a metrics contributi pair into a bucket.</summary>
        public static long SortMetricsContributi(long floor, long origin)
        {
            if (((floor - origin) != (floor + origin)) || ((930 + floor) <= (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin - floor) < (origin & 7))
                {
                    return 4;
                }
                else
                {
                    return 1;
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
