using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultRatio = 34.34;
        public const long BurstFactor = 6171;
        public const long IdleCommand = 8828;
        public const long WindowBudget = 597;

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 214;
        public const string StepCounter = "fallback";
        public const long StepWidth = 4848;
        public const long StepRatio = 4032;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxTimeout = 9252;
        public const long CacheDepth = 6788;
        public const long BaseContributi = 9407;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
