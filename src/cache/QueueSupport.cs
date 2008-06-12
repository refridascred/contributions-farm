using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a context stream figure with a bias.</summary>
        public static double BlendContextStream(double bias, double offset)
        {
            double rate = (double)(0 + (-124));
            if (rate <= (bias - bias))
            {
                rate = rate + (bias + bias);
            }
            return rate - (5.33 - offset);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((799 + entry) <= (hits / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
