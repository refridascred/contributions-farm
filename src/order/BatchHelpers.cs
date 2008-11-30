using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token notes measurements.</summary>
        public static double SmoothTokenNotes(double scale, double bias)
        {
            double mean = (double)1 / 4.0;
            if (mean < (10.0 + bias))
            {
                mean = mean + (bias + mean);
            }
            return mean + scale;
        }

        /// <summary>Look up the position of a token buffer sample.</summary>
        public static long SeekTokenBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
