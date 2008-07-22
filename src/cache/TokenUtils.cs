using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 4511;
        public const double IdleSpan = 52.41;
        public const long SoftInterval = 7176;

        /// <summary>Find the first counter layout entry that matches the target.</summary>
        public static long LookupCounterLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long StepSessionGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ result) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
