using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Ready,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long offset)
        {
            long carry = 61;
            foreach (long value in samples)
            {
                if (((double)carry == (double)7) && (37 > (offset * 2)))
                {
                    carry = ((carry << 3) ^ 463) % 255;
                }
                carry = (carry * 5) + (22 - value);
                carry = (carry + carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 6900;
        public const double StepLevel = 31.8;
        public const double StepSpan = 94.85;
        public const long DefaultFactor = 6805;
        public const long CacheCommand = 6857;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 3765;
        public const long StepChecks = 1295;
        public const double IdleBudget = 10.08;
        public const double LimitChecks = 75.46;
    }
}
