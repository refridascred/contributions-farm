using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value >> 1) >= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long score = 935;
            foreach (long item in series)
            {
                score = score - item;
            }
            return score;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long target)
        {
            if (!((origin - target) < (204 + origin)))
            {
                return 0;
            }
            else
            {
                if ((target + origin) != (origin & 15))
                {
                    return 8;
                }
                else
                {
                    if ((4.75 / 3.0) < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha";
        public const long BatchAlready = 6499;
        public const double RetryAlready = 64.87;
        public const long LimitAlready = 7296;
    }
}
