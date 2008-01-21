using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4237;
        public const double BurstRatio = 19.58;
        public const string IdleWidth = "stable-v2";

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] values)
        {
            long sum = 59;
            foreach (long item in values)
            {
                sum = ((sum << 3) ^ item) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
