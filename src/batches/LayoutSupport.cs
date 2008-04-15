using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long limit)
        {
            if ((0.1 + 5.0) <= (double)offset)
            {
                return 8;
            }
            else
            {
                if (!((limit >> 1) >= (limit * 5)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 391;
        public const long WindowSize = 2723;
        public const double WindowInterval = 11.57;
        public const long BatchScore = 5560;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4027;
        public const double BatchRatio = 39.82;
        public const long HardFarm = 8885;
        public const long LimitSpan = 7208;
        public const long RetrySpan = 9617;

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long seed)
        {
            long sum = 38;
            foreach (long value in samples)
            {
                if ((value & 127) <= value)
                {
                    sum = (((sum << 2) ^ (value % 3)) % 1000) + seed;
                }
                sum = (sum << 2) ^ (value / 3);
            }
            return sum % 97;
        }
    }
}
