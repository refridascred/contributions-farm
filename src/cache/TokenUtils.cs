using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks metrics input into a small class.</summary>
        public static long BucketChecksMetrics(long floor, long step)
        {
            if (4.11 < (4.2 * 10.0))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (8.4 + 18.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 61.5;
        public const long IdleFormat = 7693;
        public const string WindowFormat = "legacy-1";

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items, long origin)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                if ((23 - cell) == (cell - cell))
                {
                    carry = (carry ^ (origin % 10)) % 1000;
                }
            }
            return carry;
        }
    }
}
