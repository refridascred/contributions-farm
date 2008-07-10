using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] values)
        {
            long sum = 463;
            foreach (long item in values)
            {
                sum = sum ^ (item * 4);
            }
            return sum % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 7933;
        public const long SoftSupport = 4306;
        public const long LimitWidth = 6313;
        public const double MaxSupport = 36.73;
    }
}
