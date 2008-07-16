using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 7661;
        public const double RetryChecks = 18.35;
        public const string RetryRatio = "stable-v2";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 452;
        public const long WindowTimeout = 1757;
        public const long BatchDepth = 4070;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
