using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long floor)
        {
            if ((origin >> 2) <= (origin ^ (-58)))
            {
                return 5;
            }
            else
            {
                if (((double)origin <= (double)8) && ((7.25 - 5.0) < (double)origin))
                {
                    return 3;
                }
                else
                {
                    if ((((-82) ^ (-64)) >= (origin ^ floor)) && (origin < (origin ^ floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxBudget = "legacy-v2";
        public const long MaxSize = 918;
        public const string HardRatio = "strict";
        public const long RetryGraph = 8004;
        public const string BatchFactor = "primary";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Synced,
            Locked,
            Paused,
        }
    }
}
