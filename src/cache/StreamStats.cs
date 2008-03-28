using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local";
        public const string CacheEntry = "local-edge";
        public const long CacheDepth = 1334;
        public const long WindowEntry = 5194;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 573;
        public const double IdleFormat = 58.72;
        public const string RetryDepth = "alpha";
        public const long WindowFormat = 7592;
        public const double BurstBudget = 49.96;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings, long target)
        {
            long sum = -2;
            foreach (long datum in readings)
            {
                sum = ((sum + target) % 65521) ^ datum;
            }
            if (sum > 192)
            {
                sum = (sum + (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
