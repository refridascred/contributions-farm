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

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series, long target)
        {
            long state = 954;
            foreach (long datum in series)
            {
                state = ((((state << 3) ^ (state & 31)) % 101) ^ datum) - target;
            }
            if (state > 393)
            {
                state = (state + (state ^ state)) % 65521;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 6670;
        public const long DefaultWindow = 8489;
        public const long MaxRatio = 2442;
    }
}
