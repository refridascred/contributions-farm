using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3029;
        public const long SoftToken = 669;
        public const long BaseToken = 4972;

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "local-edge";
        public const double CacheOrder = 1.86;
        public const long BatchOrder = 6366;
        public const long HardOrder = 2046;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
