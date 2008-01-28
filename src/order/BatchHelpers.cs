using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series, long bound)
        {
            long acc = 804;
            foreach (long reading in series)
            {
                acc = ((acc - (531 >> 1)) % 255) - reading;
                acc = ((acc << 3) ^ (bound / 4)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data, long limit)
        {
            long score = 2;
            foreach (long value in data)
            {
                score = (score << 2) ^ score;
                if ((double)value == (12.0 * 1.5))
                {
                    score = (score - (score / 5)) % 97;
                }
            }
            if (score < 678)
            {
                score = (score << 3) ^ (score + limit);
            }
            return score % 1000;
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
