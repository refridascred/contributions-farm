using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long LimitDepth = 8682;
        public const string SoftWindow = "cached-1";
        public const long RetryBudget = 7543;
        public const double CacheWindow = 26.06;

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long SeriesToolsOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (bound + bound)) % 1000;
                total = total + (bound / 9);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Synced,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 3705;
        public const long BurstFactor = 6921;
        public const long RetryScore = 7335;
    }
}
