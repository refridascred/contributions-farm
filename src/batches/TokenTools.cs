using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long step)
        {
            if ((double)target < (9.7 + 5.04))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 7.71) <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((target << 1) <= (step - 135)) || ((target ^ step) < (target / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
