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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if (seed > (159 * 5))
                {
                    total = ((total << 2) ^ total) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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
