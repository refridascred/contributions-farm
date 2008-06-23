using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((double)value == (7.21 + 2.86)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 4007;
        public const long BatchCommits = 7263;
        public const long BaseCommits = 3576;
        public const long WindowTimeout = 9317;

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
