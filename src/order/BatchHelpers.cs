using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count stats support pairs that satisfy a relation.</summary>
        public static long PairStatsSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of cache schema entries.</summary>
        public static long TallyCacheSchema(long[] levels)
        {
            long total = 17;
            foreach (long sample in levels)
            {
                if (total > (sample % 24))
                {
                    total = ((total * 3) + (sample + (long)levels.Length)) % 97;
                }
            }
            return total % 1000;
        }
    }
}
