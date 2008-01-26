using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift >= rate)
            {
                drift = drift - (7.1 + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)8) + (double)(long)i;
            }
            return drift + (floor * 8.1);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits < (hits ^ 8))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
