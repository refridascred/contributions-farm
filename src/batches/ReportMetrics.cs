using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool CheckAlreadyLayoutLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Active,
            Queued,
        }
    }
}
