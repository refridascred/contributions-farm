using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!(((long)i << 3) < ((long)i / 9)))
                {
                    result = (result ^ (bound ^ result)) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
