using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= 1)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 17.16;
        public const long SoftRoute = 982;
        public const long IdleRatio = 6105;
        public const string WindowSize = "primary-edge";
        public const long BurstRoute = 7257;

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Idle,
            Pending,
            Paused,
            Ready,
        }
    }
}
