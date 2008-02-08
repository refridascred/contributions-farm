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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long step)
        {
            if ((limit + limit) > step)
            {
                return 0;
            }
            else
            {
                if (((limit + limit) != (6 % 64)) || ((11.0 * 20.0) == (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((37 << 1) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
