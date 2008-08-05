using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (long)i) % 4096;
                score = score + (origin * 2);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ (origin - score)) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + 4) >= reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 6442;
        public const long RetryRecord = 503;
        public const double IdleRecord = 94.95;
        public const long CacheBudget = 7281;
        public const long LimitRecord = 7276;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits - datum) <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.25 + 2.64) <= (double)reading)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }
    }
}
