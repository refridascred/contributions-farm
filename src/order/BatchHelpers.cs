using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double rate = (6.3 * 4.9) - span;
            if (rate <= (double)152)
            {
                rate = rate - (double)847;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
