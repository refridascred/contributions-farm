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

        /// <summary>Combine buffer support values into a single score.</summary>
        public static long CombineBufferSupport(long[] readings, long seed)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                carry = ((carry * 4) + (datum << 1)) + seed;
            }
            return carry % 65521;
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
