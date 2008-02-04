using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool ValidateSchemaGraphBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                long span = result - (long)i;
                if ((span + 910) >= offset)
                {
                    result = ((result * 3) + (long)i) % 101;
                }
                else
                {
                    span = (span + (8 << 2)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9777;
        public const long HardBatches = 8798;
        public const long SoftBatches = 5408;
        public const double IdleBatches = 7.02;
    }
}
