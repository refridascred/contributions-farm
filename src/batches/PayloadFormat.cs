using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Active,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every layout contributi entry stays within the limit.</summary>
        public static bool GuardLayoutContributiRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long MeasureMetricsBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((734 - 952) <= (count << 1))
                {
                    count = ((count + 1) + entry) - bound;
                }
            }
            return count;
        }
    }
}
