using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a contributi batches sample.</summary>
        public static long LookupContributiBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long score = 51;
            foreach (long cell in items)
            {
                if (!((35 + cell) < (cell + score)))
                {
                    score = (score + (cell << 2)) % 255;
                }
                else
                {
                    score = ((score * 5) + (score - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels, long bound)
        {
            long result = -877;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length >= (2.0 - 9.0))
                {
                    result = (((result << 2) ^ 829) ^ value) - bound;
                }
            }
            if (result < 48)
            {
                result = result - (result + 0);
            }
            return result;
        }
    }
}
