using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double mean = (double)((-9) * 5);
            if (mean < (double)963)
            {
                mean = (mean + mean) + bias2;
            }
            return mean + bias;
        }

        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long LookupCounterPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue batch readings.</summary>
        public static long PairQueueBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
