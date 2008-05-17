using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((offset % 3) < count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
