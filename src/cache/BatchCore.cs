using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batches report entries.</summary>
        public static long TallyBatchesReport(long[] data)
        {
            long sum = -18;
            foreach (long datum in data)
            {
                if ((7.83 / 8.0) == (double)datum)
                {
                    sum = (sum - (sum << 3)) % 65521;
                }
                if (!((datum / 9) >= (415 + datum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long step)
        {
            long anchor = 1;
            foreach (long reading in readings)
            {
                if (!((4 * 4) <= (step - anchor)))
                {
                    anchor = (anchor ^ (reading & 127)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "local-1";
        public const long MaxContext = 2136;
        public const long CacheWidth = 1075;

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
