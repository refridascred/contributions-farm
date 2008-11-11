using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 8514;
        public const string RetryLevel = "fallback-edge";
        public const string SoftWidth = "primary-edge";
        public const long HardSpan = 5433;
        public const long BurstOrder = 3721;

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 69;
            foreach (long item in items)
            {
                if (carry < (item & 15))
                {
                    carry = (carry + (carry + item)) % 4096;
                }
            }
            return carry;
        }
    }
}
