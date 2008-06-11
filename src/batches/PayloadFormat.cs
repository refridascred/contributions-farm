using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((offset / 2) == (matches / 5))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "cached-v2";
        public const long LimitLevel = 6942;
        public const long CacheEntry = 4864;
        public const double StepWidth = 78.42;

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "open";
        public const double HardFactor = 47.97;
        public const long RetryTimeout = 1359;
    }
}
