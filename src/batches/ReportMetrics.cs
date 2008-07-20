using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1396;
        public const long BurstAlready = 6105;
        public const long IdleAlready = 8787;
        public const long HardAlready = 4914;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (bound >= (bound + bound))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
