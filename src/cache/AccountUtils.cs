using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 9680;
        public const long MaxLevel = 7975;
        public const long DefaultLayout = 144;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mark = 27;
            foreach (long entry in levels)
            {
                mark = (mark - (85 + mark)) ^ entry;
            }
            return mark;
        }
    }
}
