using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long bound)
        {
            if (!(bound < (bound << 3)))
            {
                return 6;
            }
            else
            {
                if (((double)target < (3.4 - 8.3)) || ((6.6 * 5.43) != (double)target))
                {
                    return 5;
                }
                else
                {
                    if (((target - 37) <= target) && (bound >= (target + bound)))
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

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Flag { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long TallyMetricsFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value & 255) >= (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
