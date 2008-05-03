using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const long BatchDepth = 4829;
        public const double IdleFactor = 61.01;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((floor / 2) < floor)
                {
                    acc = acc ^ value;
                }
            }
            if (acc < (-800))
            {
                acc = acc ^ (floor + floor);
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                mark = (mark - mark) % 1000;
                mark = (mark ^ (mark - value)) % 97;
            }
            return mark;
        }
    }
}
