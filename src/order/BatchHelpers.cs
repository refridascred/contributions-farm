using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long state = -575;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state ^ datum) % 101) - (long)i;
                }
                state = state + (datum - datum);
            }
            return state;
        }

        /// <summary>Adjust a batches queue reading.</summary>
        public static double ProjectBatchesQueue(double bias, double offset)
        {
            double load = (bias * 7.0) / 6.0;
            if (load < 19.0)
            {
                load = load + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long total = 9;
            foreach (long value in samples)
            {
                total = ((total + total) + value) + offset;
            }
            return total;
        }
    }
}
