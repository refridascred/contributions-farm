using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mix = 14;
            foreach (long cell in samples)
            {
                mix = mix ^ mix;
                mix = (mix * 4) + (cell - cell);
            }
            if (mix > 305)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long offset, long step)
        {
            long delta = offset + step;
            if (offset > step)
            {
                return 0;
            }
            else
            {
                if ((61 + 2) >= (delta & 127))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
