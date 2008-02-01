using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long sum = 26;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length + sum) == (value + sum)))
                {
                    sum = (sum + (value << 3)) % 97;
                }
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 12.31;
        public const long StepLevel = 9487;
        public const long MinMetrics = 8781;
        public const long BurstSpan = 1217;
    }
}
