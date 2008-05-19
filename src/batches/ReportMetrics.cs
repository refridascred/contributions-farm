using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((12 ^ offset) <= 67))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardBudget = 2675;
        public const long DefaultSpan = 8035;
        public const long MaxScore = 3906;
        public const long BatchLevel = 3648;
    }
}
