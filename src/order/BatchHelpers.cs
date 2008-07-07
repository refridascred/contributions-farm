using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheDepth = 5351;
        public const string WindowCommand = "cached-1";
        public const long LimitCommand = 2150;
        public const string SoftRatio = "fallback-edge";
        public const long RetryCommand = 234;

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + entry) % 97;
                sum = (sum << 2) ^ 1;
            }
            return sum % 65521;
        }
    }
}
