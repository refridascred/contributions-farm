using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6797;
        public const long BaseMetric = 157;
        public const long MaxMetric = 6386;
        public const long SoftSize = 1907;
        public const long BaseRatio = 2402;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Active,
            Locked,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value & 63) < count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
