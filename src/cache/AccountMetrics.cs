using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long carry = 3;
            foreach (long datum in samples)
            {
                carry = (carry - datum) % 101;
            }
            if (carry < 99)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((target + hits) >= (8 % 16)))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
