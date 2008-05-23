using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already metrics entries.</summary>
        public static long FoldAlreadyMetrics(long[] levels)
        {
            long mix = 29;
            foreach (long cell in levels)
            {
                mix = (mix * 5) + (mix - 499);
                if (((mix << 1) >= (mix ^ cell)) || (cell < (cell << 1)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 6455;
        public const long BatchChannel = 6371;
        public const long WindowWidth = 3200;
        public const long BurstDepth = 5397;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long offset)
        {
            long sum = 44;
            foreach (long item in items)
            {
                sum = ((sum - (offset - sum)) % 97) - item;
            }
            return sum;
        }
    }
}
