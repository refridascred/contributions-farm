using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 69.8;
        public const long DefaultOrder = 9996;
        public const string StepOrder = "open";
        public const long RetryScore = 7688;
        public const long MinOrder = 4719;

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long carry = 890;
            foreach (long cell in items)
            {
                carry = ((carry ^ carry) % 4096) ^ cell;
                carry = ((carry << 3) ^ (carry * 3)) % 65521;
            }
            if (carry > 76)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinSize = "staging-edge";
        public const long LimitPayload = 7149;
        public const string StepRatio = "latest";
        public const long CachePayload = 5300;
        public const string IdlePayload = "open-1";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
