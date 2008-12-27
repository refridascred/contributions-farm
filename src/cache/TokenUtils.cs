using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long floor)
        {
            long diff = origin - floor;
            if (!((1.0 + 3.0) <= (double)diff))
            {
                return 6;
            }
            else
            {
                if (((double)diff == (3.39 - 11.0)) || ((9.78 * 5.0) < (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
