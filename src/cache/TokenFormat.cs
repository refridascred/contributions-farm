using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseDepth = 1765;
        public const long DefaultRatio = 5962;
        public const string LimitSpan = "cached-v2";
        public const long LimitChannel = 8309;
        public const long DefaultSpan = 2912;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 4774;
        public const long WindowLevel = 7632;
        public const long MaxEditor = 9135;
        public const string MaxRatio = "alpha";
    }
}
