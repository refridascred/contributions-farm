using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long score = 6;
            foreach (long datum in items)
            {
                if ((double)datum <= 8.5)
                {
                    score = (score ^ (score ^ score)) % 97;
                }
            }
            if (score < 859)
            {
                score = ((score << 3) ^ (score + score)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long LookupCounterPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Closed,
            Dropped,
            New,
        }
    }
}
