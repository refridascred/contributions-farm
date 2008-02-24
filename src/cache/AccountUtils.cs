using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc * 3) + (long)i;
                acc = ((acc * 5) + (seed % 2)) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter window sample.</summary>
        public static long SeekFilterWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Closed,
            Stale,
            Draft,
        }
    }
}
