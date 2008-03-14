using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long CountCacheBatchHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9 + 2) == (hits - hits))
                {
                    hits = ((hits + 1) ^ value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long MeasureAlreadyGithubfarmGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(limit >= (tally / 8)))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 3) ^ (sum / 3)) % 255;
                sum = (sum - (sum ^ origin)) % 255;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
