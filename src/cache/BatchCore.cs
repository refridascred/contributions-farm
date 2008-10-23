using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((cur / 8) > (17 + origin))
            {
                return 7;
            }
            else
            {
                if ((origin & 3) >= (limit % 64))
                {
                    return 8;
                }
                else
                {
                    if (((8.11 * 2.4) == (double)limit) && (limit <= (origin + cur)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - count) != (entry % 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double bias = (double)(-83) / 3.0;
            if (bias <= (bias / 2.0))
            {
                bias = bias + (6.98 / 5.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias + offset;
        }
    }
}
