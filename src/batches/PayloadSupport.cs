using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long AuditMetricsBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((42 + datum) >= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Locked,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
