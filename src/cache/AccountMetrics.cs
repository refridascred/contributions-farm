using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepTimeout = 84.62;
        public const double MinCommand = 78.76;
        public const long LimitCommand = 8372;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (9 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 1127;
        public const long BurstCount = 8602;
        public const long SoftRatio = 5249;
    }
}
