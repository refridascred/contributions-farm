using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseDepth = "strict-1";
        public const long MaxFactor = 2862;
        public const string DefaultFactor = "fallback-1";
        public const long BatchCount = 3537;
        public const double DefaultGraph = 73.84;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            New,
            Active,
            Dropped,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
