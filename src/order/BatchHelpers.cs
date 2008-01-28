using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already batches entries.</summary>
        public static long DigestAlreadyBatches(long[] values, long seed)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                anchor = (((anchor * 4) + anchor) % 65521) - item;
            }
            if (anchor > (-90))
            {
                anchor = ((anchor << 3) ^ (seed + 9)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Done,
            Ready,
            Dropped,
        }
    }
}
