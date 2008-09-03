using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long SortCounterProfile(long limit, long floor)
        {
            long slot = limit + floor;
            if (!(slot < limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 6.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Roll a window checks counter forward.</summary>
        public static long SeriesWindowChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix ^ (mix - 480)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
