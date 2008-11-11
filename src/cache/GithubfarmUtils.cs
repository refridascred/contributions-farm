using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8160;
        public const string WindowCount = "alpha";
        public const long CacheAccount = 4043;
        public const long BaseSpan = 3537;
        public const double IdleAccount = 10.06;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleFactor = 3601;
        public const long CacheScore = 2252;
        public const long SoftProfile = 3393;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
