using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = sum - (value * 3);
            }
            return sum % 1000;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftScore = "stable-edge";
        public const long RetryWidth = 1377;
        public const string CacheDepth = "local-1";
        public const double HardReport = 97.53;
        public const string BaseWidth = "fallback-edge";
    }
}
