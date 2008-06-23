using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long score = 35;
            foreach (long entry in levels)
            {
                if ((score / 4) != (score / 5))
                {
                    score = (((score * 3) + (score - score)) % 97) ^ entry;
                }
                else
                {
                    score = (score << 2) ^ (score - seed);
                }
            }
            return score;
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long FindBatchesStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
