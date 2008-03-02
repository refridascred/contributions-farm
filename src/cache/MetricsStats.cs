using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 4945;
        public const double CacheEntry = 16.11;
        public const long HardEntry = 8594;
        public const long BurstEntry = 6711;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 25;
            foreach (long cell in samples)
            {
                result = ((result + (result + result)) % 255) - cell;
                if ((double)result < (15.0 - 0.21))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
