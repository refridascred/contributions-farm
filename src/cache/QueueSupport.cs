using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window context values into a single score.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long anchor = -420;
            foreach (long cell in samples)
            {
                if (cell >= 2)
                {
                    anchor = (anchor + (cell / 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits >> 4) >= (seed / 3))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Paused,
            Closed,
            Dropped,
        }
    }
}
