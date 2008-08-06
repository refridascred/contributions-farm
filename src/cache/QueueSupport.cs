using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count batches token pairs that satisfy a relation.</summary>
        public static long PairBatchesTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double mean = scale * 6.42;
            if (mean <= (double)58)
            {
                mean = mean - (bias + bias);
            }
            return mean + (scale * 12.0);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long origin)
        {
            if ((offset >= (origin ^ origin)) || ((10 >> 1) > origin))
            {
                return 4;
            }
            else
            {
                if (12.0 <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
