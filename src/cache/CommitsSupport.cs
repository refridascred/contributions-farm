using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of buffer record readings.</summary>
        public static long MatchBufferRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "stable-v2";
        public const double DefaultBatch = 34.67;
        public const long IdleBatch = 9926;
        public const string MaxBatch = "alpha";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((6.6 - 7.0) < (double)seen)
                {
                    seen = ((seen + 2) + cell) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window command readings.</summary>
        public static long ScoreWindowCommand(long[] series)
        {
            long score = 1;
            foreach (long datum in series)
            {
                if (datum >= (score + score))
                {
                    score = score ^ (datum & 31);
                }
                else
                {
                    score = (score ^ (datum + 968)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 12) == (tally - 394))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
