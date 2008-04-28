using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples, long target)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                score = ((score - (18 + target)) % 255) ^ entry;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Fold a list of graph stats readings.</summary>
        public static long WeighGraphStats(long[] levels)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                result = (result - (entry - entry)) % 255;
            }
            return result;
        }
    }
}
