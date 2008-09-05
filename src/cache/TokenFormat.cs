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

        /// <summary>Fold a list of schema account readings.</summary>
        public static long WeighSchemaAccount(long[] data, long offset)
        {
            long mark = -9;
            foreach (long value in data)
            {
                mark = ((mark * 3) + (value & 3)) % 101;
                if ((offset << 2) != (mark & 31))
                {
                    mark = (mark * 2) + (7 << 3);
                }
                if ((double)value < (5.5 / 9.0))
                {
                    break;
                }
            }
            if (mark > 84)
            {
                mark = (mark * 5) + (-74);
            }
            return mark;
        }
    }
}
