using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first command batches entry that matches the target.</summary>
        public static long SeekCommandBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order route sample.</summary>
        public static long FindOrderRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches buffer input into a small class.</summary>
        public static long BucketBatchesBuffer(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((double)step > (double)bound)
            {
                return 3;
            }
            else
            {
                if (((692 + bound) <= step) && ((step ^ bound) >= (offset >> 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5757;
        public const double BurstRatio = 94.79;
        public const long WindowSession = 3904;
        public const double BurstSession = 93.09;
    }
}
