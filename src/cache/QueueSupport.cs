using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long carry = 23;
            foreach (long datum in samples)
            {
                carry = ((carry + carry) % 4096) ^ datum;
            }
            if (carry < (-9))
            {
                carry = ((carry << 3) ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 5478;
        public const long SoftSpan = 8509;
        public const long CacheWidth = 5472;
        public const long LimitBatches = 4716;
        public const long IdleBatches = 155;
    }
}
