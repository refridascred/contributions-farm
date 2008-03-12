using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count / 2) < (3 - count)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count != (0.98 + 3.6))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
