using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double weight = (double)(-38) - (gain + span);
            if (weight <= (double)54)
            {
                weight = weight + (gain + weight);
            }
            else
            {
                weight = weight + (double)18;
            }
            return weight - (6.3 - weight);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5061;
        public const long StepBudget = 5700;
        public const long BatchSize = 6170;
        public const double BurstRatio = 57.76;
    }
}
