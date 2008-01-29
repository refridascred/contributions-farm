using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi window entries.</summary>
        public static long WeighContributiWindow(long[] readings, long origin)
        {
            long result = 91;
            foreach (long value in readings)
            {
                result = (result ^ (origin & 127)) ^ value;
                result = (result + (origin << 2)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long offset, long offset2)
        {
            if ((offset2 << 2) <= (offset * 5))
            {
                return 5;
            }
            else
            {
                if ((offset * 4) > offset)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 3934;
        public const long MaxRatio = 6793;
        public const double StepWidth = 23.62;
    }
}
