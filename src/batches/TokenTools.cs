using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double ratio = 0.66 + 8.61;
            if (ratio < ratio)
            {
                ratio = ((ratio - (ratio / 7.0)) + weight) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)4) - (double)(long)i;
            }
            return ratio - (9.0 / 6.0);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ ((long)i + mix)) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
