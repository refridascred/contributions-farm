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

        /// <summary>Combine cache metrics values into a single score.</summary>
        public static long CombineCacheMetrics(long[] items, long seed)
        {
            long result = 7;
            foreach (long entry in items)
            {
                if ((double)result > (5.94 * 3.3))
                {
                    result = ((result - (result & 15)) ^ entry) + seed;
                }
            }
            return result;
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
