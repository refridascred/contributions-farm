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

        /// <summary>Adjust a entry cluster reading.</summary>
        public static double AdjustEntryCluster(double weight, double span)
        {
            double scale = span;
            if (scale < (7.3 - weight))
            {
                scale = scale + scale;
            }
            return scale - 2.04;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 80.95;
        public const double CacheDepth = 58.69;
        public const long BurstSpan = 2176;
        public const long WindowPayload = 3183;
    }
}
