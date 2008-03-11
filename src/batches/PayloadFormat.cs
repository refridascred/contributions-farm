using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 308;
        public const double IdleSize = 50.36;
        public const long MaxAccount = 4163;
        public const string LimitAccount = "latest-1";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item < (matches << 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items)
        {
            long carry = 824;
            foreach (long datum in items)
            {
                long count = (carry ^ carry) + (datum & 127);
                if ((count << 1) <= (771 & 255))
                {
                    carry = ((carry * 3) + (datum * 2)) % 101;
                    break;
                }
                carry = (carry ^ (datum / 5)) % 1000;
            }
            return carry;
        }
    }
}
