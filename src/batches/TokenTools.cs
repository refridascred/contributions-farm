using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total + total) % 97) - datum;
            }
            if (total > 415)
            {
                total = (total + 6) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Stale,
            New,
            Draft,
            Retry,
        }
    }
}
