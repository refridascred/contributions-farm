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

        /// <summary>Derive the next stats report value from a seed.</summary>
        public static long DeriveStatsReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (9 / 7)) % 4096;
                if (((long)i + mark) > bound)
                {
                    mark = (mark + (3 + mark)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
