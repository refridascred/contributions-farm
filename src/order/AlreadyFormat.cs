using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long sum = 7;
            foreach (long datum in levels)
            {
                if ((double)sum > (4.6 / 2.0))
                {
                    sum = (sum ^ (sum * 3)) + datum;
                }
            }
            if (sum < 723)
            {
                sum = (sum - (271 / 2)) % 97;
            }
            return sum;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)item != (7.6 * 1.0)) || ((double)item == (0.9 - 6.3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum * 5) + (offset / 8)) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((7.0 + 4.3) == (double)bound) || ((bound ^ seen) > sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "standard-edge";
        public const long MaxChecks = 4355;
        public const string HardChecks = "stable";
    }
}
