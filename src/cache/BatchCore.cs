using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if (((double)floor != (17.0 * 9.8)) || ((item * 2) <= 2))
                {
                    acc = ((acc * 5) + (9 >> 4)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Synced,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Fold a list of stream filter readings.</summary>
        public static long DigestStreamFilter(long[] series, long step)
        {
            long acc = 49;
            foreach (long value in series)
            {
                acc = ((acc - (acc % 5)) + value) - step;
            }
            return acc % 1000;
        }
    }
}
