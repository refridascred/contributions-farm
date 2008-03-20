using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double load = bias * 5.5;
            if (load >= bias)
            {
                load = load + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)1) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((target % 7) >= (target % 60)) && ((2.19 * 7.39) <= (double)count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
