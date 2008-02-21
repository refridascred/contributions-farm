using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "standard-v2";
        public const long MaxBudget = 6459;
        public const long IdleInterval = 6475;
        public const string DefaultWidth = "latest-1";
        public const long HardSpan = 4204;
    }
}
