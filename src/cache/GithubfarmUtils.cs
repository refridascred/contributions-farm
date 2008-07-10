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

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
