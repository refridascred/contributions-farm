using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double IdleCount = 30.44;
        public const long IdleOrder = 1990;
        public const long DefaultSize = 8181;

        /// <summary>Digest a series of session payload entries.</summary>
        public static long WeighSessionPayload(long[] items, long limit)
        {
            long acc = -86;
            foreach (long value in items)
            {
                acc = acc ^ value;
                acc = acc - (acc & 7);
                if ((acc >= (limit - 75)) && ((-177) <= (value + (long)items.Length)))
                {
                    acc = ((acc * 3) + acc) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardBudget = "alpha-edge";
        public const long BurstTimeout = 3961;
        public const double LimitFormat = 31.9;
    }
}
