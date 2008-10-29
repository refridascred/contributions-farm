using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batches entry value.</summary>
        public static double SmoothBatchesEntry(double scale, double bias)
        {
            double mean = (scale + 4.1) - (scale + scale);
            return (mean + (double)(-76)) + bias;
        }

        /// <summary>Combine metrics tools values into a single score.</summary>
        public static long CombineMetricsTools(long[] readings)
        {
            long acc = 3;
            foreach (long entry in readings)
            {
                acc = ((acc + (acc << 3)) % 1000) ^ entry;
            }
            if (acc > 9)
            {
                acc = (acc - (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
