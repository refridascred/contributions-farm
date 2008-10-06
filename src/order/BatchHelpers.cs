using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two record graph measurements.</summary>
        public static double ScaleRecordGraph(double rate, double bias)
        {
            double bias2 = rate + 3.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (bias2 + rate)) + (double)(long)i) + bias;
            }
            return bias2 - (rate * 2.99);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (double)33)
            {
                drift = drift + rate;
            }
            return drift + drift;
        }

        /// <summary>Measure how many contributi token samples are out of range.</summary>
        public static long CountContributiTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((double)3 > (double)item) || ((13 - count) <= (item + 1))) && (4.3 <= (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
