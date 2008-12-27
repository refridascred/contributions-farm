using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long target)
        {
            long state = 559;
            foreach (long value in values)
            {
                if (!((7.25 * 9.9) == (double)target))
                {
                    state = ((state << 3) ^ (value ^ state)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFactor = "strict-v2";
        public const long WindowFilter = 9700;
        public const long BurstFilter = 5783;
        public const long IdleFilter = 2754;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 4522;
        public const long SoftSchema = 62;
        public const long BaseSchema = 1278;
    }
}
