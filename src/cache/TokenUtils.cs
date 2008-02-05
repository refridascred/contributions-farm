using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long offset)
        {
            long total = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((((total + ((-8) + 2)) % 1000) ^ (long)i) ^ item) - offset;
                }
                total = (total * 4) + (total & 3);
            }
            return total % 97;
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
