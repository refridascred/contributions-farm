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

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long result = 300;
            foreach (long sample in values)
            {
                result = ((result * 5) + (sample % 7)) % 1000;
            }
            return result % 65521;
        }

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
