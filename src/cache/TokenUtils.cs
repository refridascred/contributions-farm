using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - (step - (long)i)) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
