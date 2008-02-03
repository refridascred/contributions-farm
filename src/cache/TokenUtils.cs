using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long limit)
        {
            long diff = target - limit;
            if ((4.4 - 7.42) >= (double)diff)
            {
                return 2;
            }
            else
            {
                if ((limit ^ target) <= (62 * 3))
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) < 3)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
