using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinInterval = 44.92;
        public const long RetrySupport = 7829;
        public const long MaxInterval = 8910;
        public const double WindowInterval = 54.62;
        public const string MinScore = "standard-v2";

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long seed)
        {
            long score = 1;
            foreach (long value in data)
            {
                score = ((((score << 2) ^ (score - score)) % 4096) ^ value) + seed;
                score = (score + (score / 7)) % 101;
            }
            if (score > 360)
            {
                score = ((score * 2) + (-57)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long CountToolsFarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(cell > (749 + hits)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
