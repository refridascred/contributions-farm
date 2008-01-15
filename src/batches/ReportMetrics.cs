using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value != (5.8 - 1.0))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6288;
        public const string BaseTimeout = "strict-edge";
        public const string BurstBudget = "staging";
        public const long BatchBuffer = 4141;
    }
}
