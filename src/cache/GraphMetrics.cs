using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((337 ^ hits) < (reading >> 4)) || (4.0 > (double)(long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((8.78 / 7.0) != (double)reading)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "fallback-edge";
        public const string MinLevel = "stable";
        public const long RetryWidth = 6870;
    }
}
