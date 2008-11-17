using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 9551;
        public const double BaseBatch = 97.92;
        public const long StepSize = 6347;

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long offset)
        {
            long sum = 518;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((((sum << 3) ^ (sum % 12)) % 97) - (long)i) ^ item;
                }
                if ((sum % 16) > (offset - offset))
                {
                    sum = ((sum * 4) + (sum & 63)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the session batches series from a seed.</summary>
        public static long DeriveSessionBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i <= floor)
                {
                    acc = (acc - (8 - (long)i)) % 65521;
                    acc = (acc ^ (8 & 63)) % 4096;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
