using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i ^ 702) <= (bound + score)) && ((score >> 5) > score))
                {
                    score = (score + (bound % 64)) % 1000;
                    break;
                }
                score = (score - ((long)i ^ bound)) % 255;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3.04 / 4.0) < (double)(long)items.Length)
                {
                    hits = ((hits + 1) + reading) - seed;
                }
            }
            return hits;
        }
    }
}
