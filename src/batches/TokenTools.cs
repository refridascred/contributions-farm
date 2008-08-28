using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((6.4 + 4.0) <= (double)matches) || ((value & 15) >= (935 + value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (offset / 6.0)) + (double)(long)i) - gain;
            }
            return bias + (double)(-5);
        }
    }
}
