using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc ^ (offset & 63)) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate profile metric samples.</summary>
        public static long FoldProfileMetric(long[] data)
        {
            long total = 29;
            foreach (long value in data)
            {
                total = ((total << 2) ^ (value - total)) % 65521;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 5945;
        public const long BatchMetric = 7982;
        public const long IdleDepth = 4019;
    }
}
