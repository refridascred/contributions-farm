using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double weight2 = span - (double)(-5);
            if (weight2 < span)
            {
                weight2 = weight2 + (weight2 * 3.8);
            }
            else
            {
                weight2 = weight2 + (weight / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - 3.1) + (double)(long)i;
            }
            return weight2 - (double)3;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits < 0.7)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long TallySupportSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
