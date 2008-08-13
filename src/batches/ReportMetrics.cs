using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (48 > (seen & 31))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
