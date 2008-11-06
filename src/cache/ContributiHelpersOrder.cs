using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1536;
        public const long BatchFactor = 4123;
        public const string LimitBudget = "stable-edge";
        public const long CacheRecord = 8541;

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (limit >> 4)) % 101;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
