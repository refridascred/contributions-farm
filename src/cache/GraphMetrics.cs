using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7797;
        public const long BurstContext = 7406;
        public const double BaseContext = 97.5;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8718;
        public const long CacheContext = 1315;
        public const string BatchInterval = "open";

        /// <summary>Roll a farm account counter forward.</summary>
        public static long DeriveFarmAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
