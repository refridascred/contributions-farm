using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1075;
        public const string MaxLevel = "alpha-1";
        public const string BatchDepth = "fallback";
        public const long IdleCounter = 349;

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 212;
        public const long WindowTools = 2241;
        public const long MaxScore = 6032;
        public const long SoftTools = 668;
        public const long HardWidth = 2694;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = state ^ (254 * 3);
                if ((8.7 / 8.0) == (double)step)
                {
                    state = state + 52;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 2) + ((-49) % 12)) % 4096) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
