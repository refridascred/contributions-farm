using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-1";
        public const double MinTimeout = 89.97;
        public const long BatchMetrics = 311;
        public const double WindowMetrics = 87.05;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)bound > (double)402)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
