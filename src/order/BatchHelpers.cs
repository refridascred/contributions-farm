using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit farm session readings against a rule.</summary>
        public static long CountFarmSessionHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (8.7 + 1.0))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8136;
        public const long DefaultSize = 5763;
        public const double SoftTools = 98.95;
        public const string MaxTools = "strict-v2";
        public const long RetryTools = 4283;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
