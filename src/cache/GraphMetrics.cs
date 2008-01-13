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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (step < (tally / 7))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitDepth = 52.65;
        public const long CacheBudget = 1472;
        public const string BaseEditor = "stable-edge";
        public const long DefaultSize = 8247;

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
