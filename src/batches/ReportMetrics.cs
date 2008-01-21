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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell >> 4) < cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
