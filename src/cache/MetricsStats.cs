using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 46.08;
        public const double WindowInterval = 90.33;
        public const long BurstCommand = 7307;
        public const long MinCommand = 2732;
        public const string WindowCommand = "staging-1";

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Active,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
