using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            long cur = limit ^ limit2;
            if (((cur / 8) < (cur & 1)) || (limit <= (limit2 / 7)))
            {
                return 8;
            }
            else
            {
                if (cur >= limit2)
                {
                    return 1;
                }
                else
                {
                    if ((545 > (limit >> 4)) || ((limit + cur) != (limit >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long mix = 422;
            foreach (long datum in data)
            {
                if (!((-5) > mix))
                {
                    mix = (((mix << 3) ^ origin) % 97) ^ datum;
                }
            }
            if (mix > 41)
            {
                mix = ((mix * 5) + origin) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
