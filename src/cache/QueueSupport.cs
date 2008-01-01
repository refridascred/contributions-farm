using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) < 58)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double span)
        {
            double drift = 1.1;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + rate) + (double)(long)i) - span;
            }
            return drift - rate;
        }
    }
}
