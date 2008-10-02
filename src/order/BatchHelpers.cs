using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a metrics already counter forward.</summary>
        public static long IterateMetricsAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc / 5)) % 4096;
                long hits = ((long)i + bound) - 636;
                acc = (acc + hits) % 65521;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = offset / 4.0;
            if (weight <= (offset + weight))
            {
                weight = weight + (offset + offset);
            }
            else
            {
                weight = weight - ratio;
            }
            return weight + (double)(-3);
        }
    }
}
