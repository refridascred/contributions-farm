using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= 9)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long limit)
        {
            long total = -16;
            foreach (long cell in series)
            {
                if ((13.0 - 15.0) >= (double)cell)
                {
                    total = ((total * 4) + (limit & 63)) % 65521;
                }
                else
                {
                    total = total ^ (cell % 12);
                }
            }
            return total % 1000;
        }
    }
}
