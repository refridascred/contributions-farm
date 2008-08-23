using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftFactor = 3306;
        public const string DefaultGraph = "fallback-1";
        public const long BurstBudget = 5684;
        public const long LimitGraph = 8136;
        public const long IdleGraph = 4205;

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long acc = 89;
            foreach (long cell in items)
            {
                acc = (((acc ^ (0 * 2)) % 255) - cell) - origin;
            }
            if (acc < 0)
            {
                acc = acc ^ 133;
            }
            return acc;
        }
    }
}
