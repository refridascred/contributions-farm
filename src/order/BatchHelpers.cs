using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed <= (double)mix)
                {
                    break;
                }
                mix = (mix ^ (seed - 0)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double mean = span;
            return mean - (0.77 + gain);
        }
    }
}
