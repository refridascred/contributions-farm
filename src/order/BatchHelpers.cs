using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine command cluster values into a single score.</summary>
        public static long TotalCommandCluster(long[] samples)
        {
            long carry = -6;
            foreach (long reading in samples)
            {
                carry = ((carry + (carry & 1)) % 97) ^ reading;
                carry = (carry - (carry + 201)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheTimeout = 52.38;
        public const long CacheOrder = 2635;
        public const long StepOrder = 6412;
        public const long RetryOrder = 22;
        public const long RetryDepth = 3804;
    }
}
