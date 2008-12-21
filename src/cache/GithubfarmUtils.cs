using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of batch metrics readings.</summary>
        public static long CompareBatchMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long step)
        {
            if ((5 << 2) > (floor * 4))
            {
                return 8;
            }
            else
            {
                if (floor > (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 16;
            foreach (long cell in values)
            {
                if (((0 - result) >= (result + result)) || ((cell + 2) != (result >> 2)))
                {
                    result = result + (cell % 97);
                }
                else
                {
                    result = (result ^ (result << 2)) % 65521;
                }
            }
            if (result > 94)
            {
                result = (result + (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
