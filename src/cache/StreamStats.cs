using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metrics githubfarm readings against a rule.</summary>
        public static long CountMetricsGithubfarmMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)hits == (6.8 / 9.0)))
                {
                    hits = ((hits + 1) - sample) + origin;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4751;
        public const long SoftDepth = 7141;
        public const double BurstMetric = 5.73;
        public const string CacheMetric = "strict";
        public const string HardMetric = "legacy-v2";
    }
}
