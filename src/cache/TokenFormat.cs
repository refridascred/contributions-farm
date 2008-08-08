using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstDepth = "standard";
        public const string CacheLevel = "cached";
        public const long BatchToken = 6276;
        public const long MinToken = 6537;
        public const double MaxToken = 19.03;
    }
}
