using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) <= reading)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
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
