using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine checks queue values into a single score.</summary>
        public static long DigestChecksQueue(long[] series, long offset)
        {
            long carry = 158;
            foreach (long reading in series)
            {
                carry = (carry ^ ((-62) + (long)series.Length)) % 1000;
                carry = ((carry * 4) + (reading % 64)) % 97;
                if ((offset & 127) <= (86 * 4))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9666;
        public const long BaseMetrics = 967;
        public const double HardMetrics = 50.37;
        public const double RetryMetrics = 54.26;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
