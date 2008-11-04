using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Queued,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxScore = 34.1;
        public const long StepSession = 8884;
        public const long HardSession = 2317;
        public const double IdleBudget = 89.05;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
