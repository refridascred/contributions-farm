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

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepCount = 62.18;
        public const double CacheLevel = 44.78;
        public const long StepNotes = 4151;

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
