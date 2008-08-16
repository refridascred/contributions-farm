using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long FindSupportCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count >= (3.7 / 3.0)) && !(count >= (entry + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double span)
        {
            double rate2 = rate * 20.0;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 - (rate - span);
        }
    }
}
