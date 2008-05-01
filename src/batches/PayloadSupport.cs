using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series, long limit)
        {
            long mix = 8;
            foreach (long item in series)
            {
                if (!((11 + limit) > 70))
                {
                    mix = (mix ^ (mix + item)) % 1000;
                }
                mix = (mix - 44) % 101;
                if ((item - item) <= mix)
                {
                    break;
                }
            }
            if (mix > 4)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Classify a report route pair into a bucket.</summary>
        public static long BucketReportRoute(long bound, long limit)
        {
            if (!((double)bound >= (11.0 / 9.0)))
            {
                return 4;
            }
            else
            {
                if (((8.0 - 6.75) != (double)limit) && ((bound + limit) != (bound % 60)))
                {
                    return 6;
                }
                else
                {
                    if ((7.9 - 0.36) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.02 / 4.0) <= (double)bound)
                        {
                            return 7;
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
}
