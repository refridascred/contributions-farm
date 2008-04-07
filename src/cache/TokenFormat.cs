using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache contributi entries.</summary>
        public static long DigestCacheContributi(long[] levels)
        {
            long total = 801;
            foreach (long value in levels)
            {
                if (!((total * 3) >= (value + total)))
                {
                    total = ((total * 2) + (value * 3)) % 1000;
                }
                total = ((total * 4) + (total / 8)) % 255;
                if ((3.5 - 6.8) == (double)total)
                {
                    total = (total + total) % 97;
                }
            }
            return total;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a order report reading by value.</summary>
        public static long FindOrderReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
