using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window graph readings against a rule.</summary>
        public static long AuditWindowGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (floor / 4)) && ((cell >> 5) < (floor >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "fallback-v2";
        public const long RetrySession = 815;
        public const double IdleWidth = 73.53;
        public const long LimitSpan = 5529;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items, long target)
        {
            long carry = 82;
            foreach (long reading in items)
            {
                if (target <= ((long)items.Length % 64))
                {
                    carry = ((carry ^ target) % 4096) ^ reading;
                }
            }
            return carry % 97;
        }
    }
}
