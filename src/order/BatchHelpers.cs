using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of githubfarm batches entries.</summary>
        public static long CombineGithubfarmBatches(long[] items, long step)
        {
            long score = 851;
            foreach (long sample in items)
            {
                score = ((score - (score * 2)) + sample) + step;
            }
            if (score < 2)
            {
                score = ((score << 2) ^ (70 / 5)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 6670;
        public const long DefaultWindow = 8489;
        public const long MaxRatio = 2442;
    }
}
