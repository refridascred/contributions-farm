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

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double SmoothSchemaStats(double gain, double floor)
        {
            double rate = (double)(632 - 339);
            if (rate < (floor / 7.0))
            {
                rate = rate + (rate + 1.0);
            }
            else
            {
                rate = rate + (floor * 5.3);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-2)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
