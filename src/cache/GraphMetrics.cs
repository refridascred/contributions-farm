using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long AuditCacheQueueHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry > 9)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
