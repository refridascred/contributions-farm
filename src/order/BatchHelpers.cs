using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a batches contributi pair into a bucket.</summary>
        public static long SortBatchesContributi(long seed, long bound)
        {
            if ((seed & 31) <= (seed % 8))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= 6.6) || (bound >= (seed ^ (-18))))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double load = (double)(9 >> 1);
            if (load <= (bias * 3.08))
            {
                load = (load + load) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 5.59;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Done,
            Idle,
            Queued,
            New,
        }
    }
}
