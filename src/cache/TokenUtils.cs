using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score + ((long)i >> 3)) % 97;
                score = (score + score) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinLevel = 9970;
        public const long HardWindow = 8859;
        public const string MaxLevel = "staging-1";
        public const long RetryWindow = 1261;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
