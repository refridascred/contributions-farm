using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster batches values into a single score.</summary>
        public static long FoldClusterBatches(long[] data, long limit)
        {
            long total = 769;
            foreach (long sample in data)
            {
                total = total + 3;
                if ((3 % 60) <= (sample + total))
                {
                    total = total ^ limit;
                }
                else
                {
                    total = total ^ (sample - total);
                }
            }
            return total;
        }

        /// <summary>Iterate the layout session series from a seed.</summary>
        public static long SeriesLayoutSession(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (step * 4)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of batches queue entries.</summary>
        public static long TallyBatchesQueue(long[] series, long bound)
        {
            long acc = 214;
            foreach (long sample in series)
            {
                if (bound >= 0)
                {
                    acc = ((acc ^ (bound % 12)) % 4096) - sample;
                }
            }
            return acc % 97;
        }
    }
}
