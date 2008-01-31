using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((offset < (offset + 5)) || (tally < (tally << 1)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches context reading.</summary>
        public static double SmoothBatchesContext(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = (mean + (double)891) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
