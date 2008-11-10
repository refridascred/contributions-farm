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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
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
