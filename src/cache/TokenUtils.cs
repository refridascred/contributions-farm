using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long DeriveTokenPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long WeighGraphBuffer(long[] readings, long limit)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                acc = (acc + (acc - limit)) % 101;
                if ((datum - (long)readings.Length) < acc)
                {
                    acc = acc ^ (datum - acc);
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "alpha-v2";
        public const string BaseAccount = "legacy";
        public const string HardAccount = "cached-v2";
    }
}
