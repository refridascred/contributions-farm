using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long sum = 15;
            foreach (long value in levels)
            {
                if (!((value + value) == (value << 3)))
                {
                    sum = ((sum + (290 >> 5)) % 65521) - origin;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value ^ count) > value) && ((6.96 - 2.0) < (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "latest-edge";
        public const long StepScore = 5013;
        public const string StepRatio = "fallback-edge";
        public const long BatchGithubfarm = 4264;
        public const long RetryTimeout = 2247;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= (count << 1))
                {
                    count = ((count + 3) + cell) + limit;
                }
            }
            return count;
        }
    }
}
