using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryBudget = "staging-1";
        public const long MinDepth = 9213;
        public const double HardInterval = 59.5;
        public const double IdleWidth = 27.83;
        public const long BatchTools = 7209;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = 75;
            foreach (long item in data)
            {
                sum = ((sum ^ (954 + sum)) % 255) - item;
            }
            return sum % 4096;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
