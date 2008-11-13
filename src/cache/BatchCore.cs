using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items, long seed)
        {
            long mark = 151;
            foreach (long datum in items)
            {
                if ((datum / 6) == (seed % 97))
                {
                    mark = (mark ^ (1 + mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 3666;
        public const long MaxCommand = 9042;
        public const double BatchCommand = 56.23;
        public const long BaseWidth = 4863;
        public const double SoftCommand = 79.92;
    }
}
