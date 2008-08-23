using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
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
