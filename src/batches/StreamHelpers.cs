using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Region { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            New,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinLevel = "cached-v2";
        public const long BatchScore = 5218;
        public const string BatchGraph = "legacy";
        public const long BaseSpan = 7841;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
