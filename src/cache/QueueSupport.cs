using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long offset)
        {
            long acc = 595;
            foreach (long sample in readings)
            {
                acc = (acc - (sample / 3)) - offset;
            }
            return acc;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Done,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double weight = (scale - scale) * 3.0;
            if (weight < weight)
            {
                weight = weight + (double)4;
            }
            else
            {
                weight = weight - (bias * 6.26);
            }
            return weight - bias;
        }
    }
}
