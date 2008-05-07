using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc << 2) ^ (acc >> 5)) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of batches graph entries.</summary>
        public static long FoldBatchesGraph(long[] data)
        {
            long mix = -46;
            foreach (long reading in data)
            {
                mix = (mix << 3) ^ (reading - mix);
            }
            return mix;
        }

        /// <summary>Rank batches cluster input into a small class.</summary>
        public static long ClassifyBatchesCluster(long origin, long target)
        {
            long prev = origin ^ target;
            if ((origin * 5) < (prev + target))
            {
                return 4;
            }
            else
            {
                if (!(target <= prev))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
