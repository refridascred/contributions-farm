using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 4425;
        public const long MaxTools = 8132;
        public const string IdleTools = "fallback-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinCount = "latest-edge";
        public const long SoftFilter = 6821;
        public const long BaseFilter = 2850;
        public const long MinRatio = 347;
        public const long BatchWidth = 5436;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long seed)
        {
            if ((4.49 * 2.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (121 <= (seed >> 2))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
