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

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples)
        {
            long score = 987;
            foreach (long value in samples)
            {
                if (value <= (93 << 2))
                {
                    score = score - (3 % 16);
                }
            }
            return score;
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
