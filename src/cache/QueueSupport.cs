using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)target < 0.79)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache metrics reading.</summary>
        public static double ProjectCacheMetrics(double gain, double span)
        {
            double weight = span;
            if (weight <= gain)
            {
                weight = weight - (gain / 8.0);
            }
            return weight + (7.43 - span);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Failed,
        }
    }
}
