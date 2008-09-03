using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every counter layout entry stays within the limit.</summary>
        public static bool VerifyCounterLayoutBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 2) ^ (seed * 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((57 >> 5) < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
