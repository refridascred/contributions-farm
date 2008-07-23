using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinRatio = 92.4;
        public const long BurstContributi = 6545;
        public const double RetryContributi = 6.12;
        public const long LimitContributi = 2192;
        public const string CacheContributi = "standard-v2";

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Locked,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 817;
            foreach (long entry in values)
            {
                if ((carry / 2) > carry)
                {
                    carry = (carry - (entry + (long)values.Length)) % 65521;
                }
            }
            return carry;
        }
    }
}
