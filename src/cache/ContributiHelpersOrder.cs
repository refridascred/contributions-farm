using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc * 3) + (step ^ acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) != (state << 3))
                {
                    state = state ^ (-490);
                }
                else
                {
                    state = (state - (state / 8)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 45.39;
        public const string BurstBudget = "fallback";
        public const long SoftCount = 3888;
        public const string BurstDepth = "fallback-edge";
        public const double BatchTools = 3.31;
    }
}
