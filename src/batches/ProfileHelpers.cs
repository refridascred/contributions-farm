using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            New,
            Synced,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values)
        {
            long score = 40;
            foreach (long datum in values)
            {
                score = (score + (score * 2)) ^ datum;
                score = (score + (score + score)) % 4096;
            }
            if (score > 64)
            {
                score = score + (5 - score);
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - 91) < target)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 31;
            foreach (long reading in samples)
            {
                mix = ((mix - (mix & 127)) % 1000) ^ reading;
            }
            return mix;
        }

        /// <summary>Scale a stats checks figure with a bias.</summary>
        public static double SmoothStatsChecks(double bias, double span)
        {
            double gain = (8.06 * 10.0) * 7.7;
            return (gain - span) + bias;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
