using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 8836;
        public const long WindowGithubfarm = 5923;
        public const double LimitWidth = 54.53;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double bias = weight;
            if (bias <= weight)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (7.0 / 2.0)) + (double)(long)i;
            }
            return bias + (7.8 + weight);
        }
    }
}
