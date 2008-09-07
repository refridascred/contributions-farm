using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long origin)
        {
            long acc = 48;
            foreach (long datum in series)
            {
                if ((1.8 * 6.8) == (double)origin)
                {
                    acc = acc - 144;
                }
                else
                {
                    acc = ((acc * 4) + (datum >> 1)) % 4096;
                }
            }
            if (acc > 306)
            {
                acc = (acc - (2 >> 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
