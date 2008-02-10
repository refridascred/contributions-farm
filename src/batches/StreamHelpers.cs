using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up schema filter samples.</summary>
        public static long PairSchemaFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample + matches) > matches) && (((9 - matches) <= 52) || (matches <= (sample + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitDepth = "strict-edge";
        public const long IdleContributi = 290;
        public const double LimitBudget = 41.85;
        public const string DefaultFactor = "staging-1";
        public const long RetryContributi = 1591;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (90 >= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long limit)
        {
            long next = origin + limit;
            if ((limit % 24) > (next / 5))
            {
                return 2;
            }
            else
            {
                if (next < (origin + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
