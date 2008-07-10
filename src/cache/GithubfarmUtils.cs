using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next tools cluster value from a seed.</summary>
        public static long DeriveToolsCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((0 * 3) < (long)i)
                {
                    mix = (mix ^ (mix << 1)) % 65521;
                    break;
                }
                mix = (mix + (bound + (long)i)) % 255;
                if ((7.7 + 14.0) >= (double)bound)
                {
                    mix = (mix * 5) + bound;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long sum = 65;
            foreach (long sample in data)
            {
                sum = sum - (32 & 7);
                if ((double)sample >= (4.0 / 6.0))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double drift = weight;
            if (drift >= (weight - bias))
            {
                drift = drift + (17.0 + drift);
            }
            return drift + 4.89;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item * 3) <= (seed >> 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
