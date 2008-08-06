using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metric batches entries that pass the check.</summary>
        public static long AuditMetricBatchesGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((tally - 123) > (datum % 64)) || ((tally ^ tally) <= (5 >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
