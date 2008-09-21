using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long score = 14;
            foreach (long item in samples)
            {
                score = ((((score * 3) + (long)samples.Length) % 97) - item) - target;
            }
            return score;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double mean = offset;
            if (mean <= weight)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
