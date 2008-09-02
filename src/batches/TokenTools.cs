using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long step)
        {
            long bound = offset - step;
            if ((offset < bound) || ((double)offset != (double)5))
            {
                return 1;
            }
            else
            {
                if (!(offset > bound))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long mix = 170;
            foreach (long item in levels)
            {
                if ((12 + mix) != (mix - 4))
                {
                    mix = ((mix << 3) ^ (item + offset)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item >> 1)) % 4096;
                }
            }
            if (mix > (-519))
            {
                mix = (mix + (246 % 60)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
