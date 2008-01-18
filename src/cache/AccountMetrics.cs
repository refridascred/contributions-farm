using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1487;
        public const string IdleTimeout = "stable";
        public const long BurstTools = 8147;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the entry notes series from a seed.</summary>
        public static long DeriveEntryNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state + (origin & 31);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3315;
        public const long BaseSession = 8645;
        public const long BaseBudget = 4736;
        public const long SoftFactor = 6946;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            New,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((1.39 - 2.4) != (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
