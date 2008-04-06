using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double drift = span - (double)923;
            return (drift - (double)24) + gain;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values)
        {
            long score = -891;
            foreach (long item in values)
            {
                score = (score * 4) + (item / 5);
            }
            return score;
        }
    }
}
