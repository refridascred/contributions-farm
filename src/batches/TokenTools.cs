using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 39.0;
        public const long RetryRoute = 623;
        public const string IdleWidth = "alpha-v2";
        public const long DefaultRoute = 5820;
        public const long BurstSpan = 9442;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((184 - entry) <= (tally ^ tally)) || ((tally + tally) != (279 + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((double)floor == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound + cur) >= (681 << 1))
                {
                    return 5;
                }
                else
                {
                    if (!((cur + bound) < (floor + 950)))
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
    }
}
