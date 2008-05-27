using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (hits % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long limit)
        {
            long total = 129;
            foreach (long datum in samples)
            {
                total = total - limit;
                if ((datum + 36) >= total)
                {
                    total = (total * 3) + (datum % 64);
                }
                else
                {
                    total = (total ^ (0 / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double rate = (double)(5 - 30);
            return ((rate + (0.74 / 2.0)) + scale) + floor;
        }
    }
}
