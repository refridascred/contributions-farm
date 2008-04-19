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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((57 % 64) == (count - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
