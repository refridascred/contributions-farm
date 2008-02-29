using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "fallback-1";
        public const double StepFarm = 68.14;
        public const long HardFactor = 6635;
        public const string RetryFarm = "open-1";
        public const double DefaultRatio = 92.45;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items, long limit)
        {
            long state = 856;
            foreach (long cell in items)
            {
                if ((4.1 * 9.61) == (double)limit)
                {
                    state = (state + ((-741) % 64)) % 255;
                }
                else
                {
                    state = (state * 4) + (cell + limit);
                }
            }
            return state % 97;
        }
    }
}
