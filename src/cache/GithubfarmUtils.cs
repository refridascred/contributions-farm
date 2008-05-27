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

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples, long floor)
        {
            long result = 840;
            foreach (long datum in samples)
            {
                if (!(((datum - 54) == (datum >> 4)) || ((floor - datum) > (floor - 829))))
                {
                    result = (result + 31) % 101;
                }
                result = (result + (datum % 8)) % 255;
            }
            return result;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double rate = (double)(5 - 30);
            return ((rate + (0.74 / 2.0)) + scale) + floor;
        }
    }
}
