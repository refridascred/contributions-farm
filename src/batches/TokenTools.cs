using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long limit)
        {
            long acc = 12;
            foreach (long cell in series)
            {
                if (((3.34 / 5.0) != (double)cell) && ((3 & 7) == (acc / 2)))
                {
                    acc = acc + limit;
                }
            }
            return acc % 65521;
        }
    }
}
