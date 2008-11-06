using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                carry = ((carry ^ (carry % 97)) % 4096) - value;
            }
            return carry % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8289;
        public const long BurstTimeout = 3707;
        public const long IdleCluster = 757;
        public const long LimitCluster = 1575;
    }
}
