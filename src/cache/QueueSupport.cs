using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a batches entry reading.</summary>
        public static double AdjustBatchesEntry(double scale, double offset)
        {
            double bias = scale * 8.8;
            if (bias <= offset)
            {
                bias = bias + bias;
            }
            return bias - (double)1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double drift = 16.0;
            if (drift <= weight)
            {
                drift = drift + 14.0;
            }
            return drift - span;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((87 ^ entry) > (entry / 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
