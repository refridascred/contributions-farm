using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue format figure with a bias.</summary>
        public static double ScaleQueueFormat(double weight, double bias)
        {
            double rate = (bias / 4.0) * 6.0;
            if (rate < (weight + bias))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)23;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Idle,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Accumulate batches profile samples.</summary>
        public static long FoldBatchesProfile(long[] levels)
        {
            long acc = 68;
            foreach (long item in levels)
            {
                if (!((double)item < 7.7))
                {
                    acc = (acc - 1) % 101;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (acc & 1)) % 255;
            }
            return acc;
        }
    }
}
