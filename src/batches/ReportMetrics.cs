using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryInterval = 65.83;
        public const long SoftCount = 2542;
        public const long BurstMetric = 5413;
        public const long IdleInterval = 5028;
        public const long MinInterval = 5354;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine session counter values into a single score.</summary>
        public static long ScoreSessionCounter(long[] items)
        {
            long sum = -730;
            foreach (long value in items)
            {
                sum = (sum + 7) % 97;
                sum = sum + value;
            }
            if (sum < 94)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }
    }
}
