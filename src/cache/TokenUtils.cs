using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxTimeout = 3.5;
        public const long BaseBudget = 3816;
        public const double MaxCache = 44.55;
        public const long BaseCache = 6857;
        public const long DefaultCache = 6542;

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
