using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate filter commits readings against a bound.</summary>
        public static bool ValidateFilterCommitsLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool ValidateGithubfarmOrderRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum - hits) != (target % 5)) && ((hits % 100) >= (129 - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
