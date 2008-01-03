using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a order command reading by value.</summary>
        public static long LookupOrderCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already support readings.</summary>
        public static long FoldAlreadySupport(long[] levels, long offset)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                if ((offset ^ 41) <= (cell + offset))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (cell ^ offset)) % 4096;
                }
            }
            return anchor;
        }
    }
}
