using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)origin > 3.22)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Idle,
            Active,
            Retry,
        }
    }
}
