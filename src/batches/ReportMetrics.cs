using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if (mark >= (floor - floor))
                {
                    mark = (mark - (floor - mark)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 9445;
        public const long BaseAlready = 2139;
        public const long IdleScore = 8851;
        public const long IdleAlready = 2515;
        public const long MinAlready = 67;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
