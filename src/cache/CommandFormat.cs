using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long step)
        {
            long next = seed + step;
            if (next > (627 % 3))
            {
                return 6;
            }
            else
            {
                if (((5.6 + 14.0) <= (double)next) && ((step & 255) <= step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long sample in readings)
            {
                if (sample >= (limit << 3))
                {
                    mark = (mark << 3) ^ (mark * 5);
                }
                else
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }
    }
}
