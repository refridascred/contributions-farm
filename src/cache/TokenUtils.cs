using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            New,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items, long seed)
        {
            long carry = 311;
            foreach (long cell in items)
            {
                carry = ((carry ^ (seed / 9)) % 4096) + cell;
            }
            if (carry < 1)
            {
                carry = (carry - (-17)) % 101;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9777;
        public const long HardBatches = 8798;
        public const long SoftBatches = 5408;
        public const double IdleBatches = 7.02;
    }
}
