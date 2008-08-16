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

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
