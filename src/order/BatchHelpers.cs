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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum <= (8 ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
