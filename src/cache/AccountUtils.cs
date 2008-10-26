using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items)
        {
            long result = 2;
            foreach (long item in items)
            {
                result = ((result - (result * 4)) % 255) + item;
            }
            return result;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit + (long)i) < result)
                {
                    result = (result << 3) ^ (limit - (long)i);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 52;
        public const string CacheCount = "standard-edge";
        public const double WindowCount = 30.49;
        public const long BaseDepth = 3030;
    }
}
