using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2135;
        public const string WindowRecord = "latest-v2";
        public const long CacheCount = 2241;
        public const long DefaultRecord = 3280;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)score == (2.4 * 17.0))
                {
                    score = score + (score & 31);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ (origin - score)) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 9158;
        public const long MinCommits = 3864;
        public const double BaseCount = 17.23;
        public const double DefaultRatio = 77.93;
        public const double HardCommits = 19.18;
    }
}
