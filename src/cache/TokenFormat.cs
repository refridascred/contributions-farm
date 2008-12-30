using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long state = 393;
            foreach (long value in values)
            {
                state = (state << 3) ^ value;
                if (value < seed)
                {
                    state = (state << 2) ^ seed;
                }
            }
            return state;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a entry stream sample.</summary>
        public static long LookupEntryStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
