using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((48 + step) >= (matches + step))
                {
                    matches = (matches + 2) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheDepth = 58.71;
        public const string IdleCounter = "cached";
        public const string WindowBudget = "legacy-v2";
        public const long RetryCounter = 3439;
        public const string BurstCounter = "fallback-edge";

        /// <summary>Roll a format already counter forward.</summary>
        public static long DeriveFormatAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = (result << 3) ^ 817;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
