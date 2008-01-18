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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((origin - 24) <= (-8))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            New,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Roll a support command counter forward.</summary>
        public static long RollSupportCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum * 3) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
