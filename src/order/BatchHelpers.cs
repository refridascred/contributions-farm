using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 7951;
        public const long BurstTimeout = 3038;
        public const long MinRatio = 5173;
        public const double StepBatch = 49.85;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] items)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                carry = (carry + (carry << 2)) ^ sample;
            }
            return carry;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
