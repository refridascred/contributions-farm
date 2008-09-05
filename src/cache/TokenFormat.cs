using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of format order entries.</summary>
        public static long DigestFormatOrder(long[] samples, long limit)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                if ((limit - 351) == (total - limit))
                {
                    total = (((total << 3) ^ (total - 0)) % 4096) + cell;
                }
                else
                {
                    total = (total - (limit % 8)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long TallySchemaEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)item != (7.51 / 8.0)) && (((16.0 - 4.9) <= (double)matches) && ((double)matches < (8.22 / 9.0))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
