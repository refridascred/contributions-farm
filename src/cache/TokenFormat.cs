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

        /// <summary>Compare every pair of editor schema readings.</summary>
        public static long OverlapEditorSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
