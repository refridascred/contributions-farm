using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((3.03 + 4.36) > (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long mark = -2;
            foreach (long sample in data)
            {
                mark = ((((mark * 2) + (mark & 255)) % 255) ^ sample) - seed;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 8255;
        public const long BatchScore = 1518;
        public const string HardDepth = "legacy-v2";
        public const double BurstWidth = 32.03;
    }
}
