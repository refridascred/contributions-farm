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

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!!(9 > (bound & 1)))
                {
                    mark = ((mark * 4) + ((long)i & 255)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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
