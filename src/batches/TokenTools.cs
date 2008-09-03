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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long acc = 357;
            foreach (long sample in series)
            {
                if (!(acc <= (sample << 1)))
                {
                    acc = (acc ^ acc) + bound;
                    continue;
                }
                else
                {
                    acc = (acc ^ 10) % 65521;
                }
                acc = acc ^ (8 & 1);
                acc = (acc - acc) % 1000;
            }
            if (acc < 6)
            {
                acc = ((acc * 5) + (acc - 0)) % 65521;
            }
            return acc % 1000;
        }
    }
}
