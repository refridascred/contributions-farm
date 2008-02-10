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

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series)
        {
            long mark = 3;
            foreach (long sample in series)
            {
                mark = (((mark << 2) ^ (mark & 3)) % 4096) - sample;
            }
            return mark % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5757;
        public const double BurstRatio = 94.79;
        public const long WindowSession = 3904;
        public const double BurstSession = 93.09;
    }
}
