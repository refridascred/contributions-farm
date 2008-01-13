using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((floor / 6) <= hits) && ((hits + hits) >= (hits - 95))) && ((double)sample < (9.49 - 3.15)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8065;
        public const double StepLayout = 50.24;
        public const string BatchLayout = "fallback-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long total = 6;
            foreach (long reading in data)
            {
                total = total + total;
                total = ((total * 5) + (reading + reading)) % 101;
                if ((double)total >= 1.88)
                {
                    total = (total * 5) + total;
                }
            }
            if (total > 1)
            {
                total = total + 2;
            }
            return total;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
