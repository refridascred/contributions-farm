using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Stale,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6781;
        public const long LimitWidth = 8635;
        public const string DefaultMetrics = "legacy-edge";
        public const double IdleInterval = 31.33;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
